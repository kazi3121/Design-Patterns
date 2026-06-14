
using System.Security.AccessControl;

var _instance = DoubleCheckedSingleton.GetInstance;
_instance.send();

var _instance2 = DoubleCheckedSingleton.GetInstance;
_instance2.send();

var Instance = LazySingleton.GetInstance;
Instance.send();


// 1.The Basic Implementation(Non-Thread-Safe)
// This is the naive approach, often called "Lazy Initialization." It works perfectly in a single-threaded environment 
// but fails miserably in multithreaded applications.

// Why this fails in Multithreading:
// If Thread A and Thread B evaluate if (_instance == null) at the exact same millisecond when the instance hasn't been created yet,
//  both will see it as null. Both threads will then call new BasicSingleton(), violating the singleton rule.
public sealed class BasicSingleton
{
    private static BasicSingleton? _instance;

    private BasicSingleton() { }

    public static BasicSingleton GetInstance
    {
        get
        {
            if (_instance == null) _instance = new BasicSingleton(); 
            return _instance;
        }
    }

    public void send()
    {
        Console.WriteLine("Hello Single object");
    }
}

// 2.Synchronized Thread - Safe Singleton(The Naive Fix)
// To fix the race condition, we can introduce a thread lock. 
// This ensures that only one thread can enter the critical section of code at a time.

// The Problem:
// While this is thread-safe, it introduces a major performance bottleneck. 
// Every single time your application requests the Instance, it has to acquire a lock,
//  even if the instance was already created months ago.Locking is computationally expensive.
public sealed class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _instance;
    private static readonly object _lock = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null) _instance = new ThreadSafeSingleton();
                return _instance;
            }
        }
    }

    public void send()
    {
        Console.WriteLine("Hello Single object");
    }
}

// 3.Double - Checked Locking(Optimized Thread Safety)
// To solve the performance bottleneck of the previous approach, we use Double-Checked Locking.

// We check if the instance is null before acquiring the lock. 
// We only lock the code if the instance actually needs to be created. Inside the lock,
//  we check a second time to ensure another thread didn't beat us to it while we were waiting for the lock.

// Note on volatile: In C#, without volatile, the compiler or the CPU hardware could theoretically reorder instructions. 
// A thread could allocate memory and publish the reference to _instance before the constructor actually finishes running. 
// Another thread would see a non-null _instance and try to use it while it's still uninitialized. volatile prevents this.
public sealed class DoubleCheckedSingleton
{
    // 'volatile' ensures that assignment to the variable completes 
    // before the instance can be accessed, preventing memory reordering optimization bugs.
    private static volatile DoubleCheckedSingleton? _instance;
    private static readonly object _lock = new object();

    private DoubleCheckedSingleton() { }

    public static DoubleCheckedSingleton GetInstance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null) _instance =  new DoubleCheckedSingleton();
                }
            }
            return _instance;
        }
    }

    public void send()
    {
        Console.WriteLine("Hello Single object");
    }
   
}

// 4. Modern C# Standard: Lazy<T> (Recommended)
// If you are using modern .NET/ C#, you don't need to manually write double-checked locking boilerplate anymore.
// .NET provides the Lazy<T> type, which is inherently thread-safe and lazily evaluated by default.

// Why this is the Best Practice:
// Performance: It uses highly optimized, low-level lazy initialization under the hood.
// Readability: Cleaner, minimal code, reducing the surface area for human error.
// Thread Safety: Fully thread-safe by default (you can optionally pass LazyThreadSafetyMode flags to the constructor if you need to tune it).
public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> _lazySingleton =
        new Lazy<LazySingleton>(() => new LazySingleton());

    private LazySingleton() { }

    public static LazySingleton GetInstance => _lazySingleton.Value;

    public void send()
    {
        Console.WriteLine("Hello Single object from lazy");
    }
}
