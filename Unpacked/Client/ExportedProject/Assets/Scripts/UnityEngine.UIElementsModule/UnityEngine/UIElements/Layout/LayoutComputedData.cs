namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C9")]
internal struct LayoutComputedData
{
	[CompilerGenerated]
	[Token(Token = "0x20005CA")]
	[UnsafeValueType]
	internal struct <Border>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001507")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20005CB")]
	[UnsafeValueType]
	internal struct <Dimensions>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001508")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20005CC")]
	[UnsafeValueType]
	internal struct <Margin>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001509")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20005CD")]
	[UnsafeValueType]
	internal struct <MeasuredDimensions>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400150A")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20005CE")]
	[UnsafeValueType]
	internal struct <Padding>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400150B")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20005CF")]
	[UnsafeValueType]
	internal struct <Position>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400150C")]
		public float FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(float), 4)]
	[Token(Token = "0x40014FA")]
	public <Position>e__FixedBuffer Position; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(float), 2)]
	[Token(Token = "0x40014FB")]
	public <Dimensions>e__FixedBuffer Dimensions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FixedBuffer(typeof(float), 6)]
	[Token(Token = "0x40014FC")]
	public <Margin>e__FixedBuffer Margin; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[FixedBuffer(typeof(float), 6)]
	[Token(Token = "0x40014FD")]
	public <Border>e__FixedBuffer Border; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[FixedBuffer(typeof(float), 6)]
	[Token(Token = "0x40014FE")]
	public <Padding>e__FixedBuffer Padding; //Field offset: 0x48
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40014FF")]
	public LayoutDirection Direction; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001500")]
	public uint ComputedFlexBasisGeneration; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001501")]
	public float ComputedFlexBasis; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001502")]
	public bool HadOverflow; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001503")]
	public uint GenerationCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4001504")]
	public LayoutDirection LastParentDirection; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001505")]
	public float LastPointScaleFactor; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[FixedBuffer(typeof(float), 2)]
	[Token(Token = "0x4001506")]
	public <MeasuredDimensions>e__FixedBuffer MeasuredDimensions; //Field offset: 0x7C

	[Token(Token = "0x17000A7A")]
	public Single* BorderBuffer
	{
		[Address(RVA = "0x1BA8510", Offset = "0x1BA7710", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600295D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000A78")]
	public static LayoutComputedData Default
	{
		[Address(RVA = "0x1BA8520", Offset = "0x1BA7720", Length = "0x1AD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600295B")]
		 get { } //Length: 429
	}

	[Token(Token = "0x17000A79")]
	public Single* MarginBuffer
	{
		[Address(RVA = "0x1B9EE60", Offset = "0x1B9E060", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600295C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000A7B")]
	public Single* PaddingBuffer
	{
		[Address(RVA = "0x1BA86D0", Offset = "0x1BA78D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600295E")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1BA8510", Offset = "0x1BA7710", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600295D")]
	public Single* get_BorderBuffer() { }

	[Address(RVA = "0x1BA8520", Offset = "0x1BA7720", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600295B")]
	public static LayoutComputedData get_Default() { }

	[Address(RVA = "0x1B9EE60", Offset = "0x1B9E060", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600295C")]
	public Single* get_MarginBuffer() { }

	[Address(RVA = "0x1BA86D0", Offset = "0x1BA78D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600295E")]
	public Single* get_PaddingBuffer() { }

}

