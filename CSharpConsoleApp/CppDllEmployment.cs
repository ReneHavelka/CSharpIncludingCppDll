using System.Runtime.InteropServices;

namespace CSharpConsoleApp
{
	internal class CppDllEmployment
	{
		[DllImport(@"C:\Users\RH\source\repos\CSharpIncludingCppDll\x64\Debug\CppDll.dll")]
		public static extern void fibonacci_init(long a, long b);

		[DllImport(@"C:\Users\RH\source\repos\CSharpIncludingCppDll\x64\Debug\CppDll.dll")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool fibonacci_next();

		[DllImport(@"C:\Users\RH\source\repos\CSharpIncludingCppDll\x64\Debug\CppDll.dll")]
		public static extern ulong fibonacci_current();

		[DllImport(@"C:\Users\RH\source\repos\CSharpIncludingCppDll\x64\Debug\CppDll.dll")]
		public static extern int fibonacci_index();

		public void GetFibonacci()
		{
			fibonacci_init(1, 1);

			do
			{
				Console.WriteLine($"{fibonacci_index()}: {fibonacci_current()}");
			}
			while (fibonacci_next());

			Console.WriteLine($"{fibonacci_index() + 1}: Fibonacci sequence values fit in an unsigned 64-bit integer.");
		}
	}
}
