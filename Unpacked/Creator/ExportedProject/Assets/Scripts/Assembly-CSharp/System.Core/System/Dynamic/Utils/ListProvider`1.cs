namespace System.Dynamic.Utils;

[DefaultMember("Item")]
[Token(Token = "0x2000243")]
internal abstract class ListProvider : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000244")]
	private sealed class <GetEnumerator>d__20 : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D2")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D3")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D4")]
		public ListProvider<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D5")]
		private int <i>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D6")]
		private int <n>5__3; //Field offset: 0x0

		[Token(Token = "0x1700022E")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000ABA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700022F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000ABC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB7")]
		public <GetEnumerator>d__20(int <>1__state) { }

		[Address(RVA = "0x810CA0", Offset = "0x80FEA0", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABA")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB8")]
		private override void System.IDisposable.Dispose() { }

	}


	[Token(Token = "0x1700022C")]
	public override int Count
	{
		[Address(RVA = "0xCF4F90", Offset = "0xCF4190", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB1")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700022A")]
	protected abstract int ElementCount
	{
		[Token(Token = "0x6000AA6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000229")]
	protected abstract T First
	{
		[Token(Token = "0x6000AA5")]
		 get { } //Length: 0
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x1700022D")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700022B")]
	public override T Item
	{
		[Address(RVA = "0xCF4FB0", Offset = "0xCF41B0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAB")]
		 get { } //Length: 48
		[Address(RVA = "0xC30E60", Offset = "0xC30060", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[ExcludeFromCodeCoverage]
		[Token(Token = "0x6000AAC")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB6")]
	protected ListProvider`1() { }

	[Address(RVA = "0xCF4B10", Offset = "0xCF3D10", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000AAD")]
	public override void Add(T item) { }

	[Address(RVA = "0xCF4B30", Offset = "0xCF3D30", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000AAE")]
	public override void Clear() { }

	[Address(RVA = "0xCF4B50", Offset = "0xCF3D50", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAF")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xCF4C00", Offset = "0xCF3E00", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB0")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xCF4F90", Offset = "0xCF4190", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB1")]
	public override int get_Count() { }

	[Token(Token = "0x6000AA6")]
	protected abstract int get_ElementCount() { }

	[Token(Token = "0x6000AA5")]
	protected abstract T get_First() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB2")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xCF4FB0", Offset = "0xCF41B0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAB")]
	public override T get_Item(int index) { }

	[Token(Token = "0x6000AA7")]
	protected abstract T GetElement(int index) { }

	[Address(RVA = "0xCF4DB0", Offset = "0xCF3FB0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__20))]
	[Token(Token = "0x6000AB4")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xCF4E40", Offset = "0xCF4040", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA8")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xC30E60", Offset = "0xC30060", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000AA9")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xCF4B10", Offset = "0xCF3D10", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000AB3")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xCF4B10", Offset = "0xCF3D10", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000AAA")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xC30E60", Offset = "0xC30060", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000AAC")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xCF4EF0", Offset = "0xCF40F0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

