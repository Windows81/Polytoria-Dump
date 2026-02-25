namespace System.Threading;

[Token(Token = "0x200020B")]
internal class SparselyPopulatedArray
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D0")]
	private readonly SparselyPopulatedArrayFragment<T> _head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D1")]
	private SparselyPopulatedArrayFragment<T> _tail; //Field offset: 0x0

	[Token(Token = "0x1700019E")]
	internal SparselyPopulatedArrayFragment<T> Tail
	{
		[Address(RVA = "0xF5DBC0", Offset = "0xF5CDC0", Length = "0x18")]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001183")]
		internal get { } //Length: 24
	}

	[Address(RVA = "0xF5DB10", Offset = "0xF5CD10", Length = "0xB0")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F7FC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001182")]
	internal SparselyPopulatedArray`1(int initialSize) { }

	[Address(RVA = "0xF5D860", Offset = "0xF5CA60", Length = "0x2A1")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001184")]
	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }

	[Address(RVA = "0xF5DBC0", Offset = "0xF5CDC0", Length = "0x18")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001183")]
	internal SparselyPopulatedArrayFragment<T> get_Tail() { }

}

