namespace System.Threading;

[DefaultMember("Item")]
[Token(Token = "0x200020D")]
internal class SparselyPopulatedArrayFragment
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D4")]
	internal readonly T[] _elements; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D5")]
	internal int _freeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D6")]
	internal SparselyPopulatedArrayFragment<T> _next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D7")]
	internal SparselyPopulatedArrayFragment<T> _prev; //Field offset: 0x0

	[Token(Token = "0x170001A1")]
	internal T Item
	{
		[Address(RVA = "0xF5D800", Offset = "0xF5CA00", Length = "0x35")]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600118A")]
		internal get { } //Length: 53
	}

	[Token(Token = "0x170001A2")]
	internal int Length
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600118B")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x170001A3")]
	internal SparselyPopulatedArrayFragment<T> Prev
	{
		[Address(RVA = "0xF5D840", Offset = "0xF5CA40", Length = "0x18")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x600118C")]
		internal get { } //Length: 24
	}

	[Address(RVA = "0xF5D740", Offset = "0xF5C940", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F7FC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001188")]
	internal SparselyPopulatedArrayFragment`1(int size) { }

	[Address(RVA = "0xF5D760", Offset = "0xF5C960", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001189")]
	internal SparselyPopulatedArrayFragment`1(int size, SparselyPopulatedArrayFragment<T> prev) { }

	[Address(RVA = "0xF5D800", Offset = "0xF5CA00", Length = "0x35")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600118A")]
	internal T get_Item(int index) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600118B")]
	internal int get_Length() { }

	[Address(RVA = "0xF5D840", Offset = "0xF5CA40", Length = "0x18")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x600118C")]
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }

	[Address(RVA = "0xF5D6C0", Offset = "0xF5C8C0", Length = "0x77")]
	[CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600118D")]
	internal T SafeAtomicRemove(int index, T expectedElement) { }

}

