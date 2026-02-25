namespace UnityEngine.UIElements;

[Token(Token = "0x20002BC")]
internal class UIRAtlasAllocator : IDisposable
{
	[Token(Token = "0x20002BF")]
	private class AreaNode
	{
		[CompilerGenerated]
		[Token(Token = "0x20002C0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B14")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x1C8F220", Offset = "0x1C8E420", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001332")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001333")]
			public <>c() { }

			[Address(RVA = "0x1C8F1D0", Offset = "0x1C8E3D0", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001334")]
			internal AreaNode <.cctor>b__9_0() { }

		}

		[Token(Token = "0x4000B10")]
		private static ObjectPool<AreaNode> s_Pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B11")]
		public RectInt rect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B12")]
		public AreaNode previous; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B13")]
		public AreaNode next; //Field offset: 0x28

		[Address(RVA = "0x1C7D1A0", Offset = "0x1C7C3A0", Length = "0x107")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001331")]
		private static AreaNode() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001330")]
		public AreaNode() { }

		[Address(RVA = "0x1C7CF10", Offset = "0x1C7C110", Length = "0xB2")]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "BuildAreas", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600132C")]
		public static AreaNode Acquire(RectInt rect) { }

		[Address(RVA = "0x1C7CFD0", Offset = "0x1C7C1D0", Length = "0xD6")]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "BuildAreas", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600132F")]
		public void AddAfter(AreaNode previous) { }

		[Address(RVA = "0x1C7D0B0", Offset = "0x1C7C2B0", Length = "0x78")]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600132D")]
		public void Release() { }

		[Address(RVA = "0x1C7D130", Offset = "0x1C7C330", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600132E")]
		public void RemoveFromChain() { }

	}

	[Token(Token = "0x20002BD")]
	private class Row
	{
		[CompilerGenerated]
		[Token(Token = "0x20002BE")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B0F")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x1C8F290", Offset = "0x1C8E490", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001329")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600132A")]
			public <>c() { }

			[Address(RVA = "0x1C8F150", Offset = "0x1C8E350", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600132B")]
			internal Row <.cctor>b__21_0() { }

		}

		[Token(Token = "0x4000B09")]
		private static ObjectPool<Row> s_Pool; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B0A")]
		private int <offsetX>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000B0B")]
		private int <offsetY>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B0C")]
		private int <width>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000B0D")]
		private int <height>k__BackingField; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B0E")]
		public int Cursor; //Field offset: 0x20

		[Token(Token = "0x170003B4")]
		private int height
		{
			[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001324")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170003B1")]
		public private int offsetX
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600131E")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600131F")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170003B2")]
		public private int offsetY
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001320")]
			 get { } //Length: 4
			[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001321")]
			private set { } //Length: 4
		}

		[Token(Token = "0x170003B3")]
		public private int width
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001322")]
			 get { } //Length: 4
			[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001323")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x1C8DE80", Offset = "0x1C8D080", Length = "0x107")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001328")]
		private static Row() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001327")]
		public Row() { }

		[Address(RVA = "0x1C8DD20", Offset = "0x1C8CF20", Length = "0xB2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001325")]
		public static Row Acquire(int offsetX, int offsetY, int width, int height) { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600131E")]
		public int get_offsetX() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001320")]
		public int get_offsetY() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001322")]
		public int get_width() { }

		[Address(RVA = "0x1C8DDE0", Offset = "0x1C8CFE0", Length = "0x90")]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001326")]
		public void Release() { }

		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001324")]
		private void set_height(int value) { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600131F")]
		private void set_offsetX(int value) { }

		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001321")]
		private void set_offsetY(int value) { }

		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001323")]
		private void set_width(int value) { }

	}

	[Token(Token = "0x4000B07")]
	private static ProfilerMarker s_MarkerTryAllocate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AFC")]
	private readonly int <maxAtlasSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000AFD")]
	private readonly int <maxImageWidth>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AFE")]
	private readonly int <maxImageHeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000AFF")]
	private int <virtualWidth>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B00")]
	private int <virtualHeight>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B01")]
	private int <physicalWidth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B02")]
	private int <physicalHeight>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B03")]
	private AreaNode m_FirstUnpartitionedArea; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B04")]
	private Row[] m_OpenRows; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B05")]
	private int m_1SidePadding; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B06")]
	private int m_2SidePadding; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B08")]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170003B0")]
	protected private bool disposed
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001314")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001315")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003A9")]
	public int maxAtlasSize
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001309")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003AB")]
	public int maxImageHeight
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600130B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003AA")]
	public int maxImageWidth
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600130A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003AF")]
	public private int physicalHeight
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001312")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001313")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003AE")]
	public private int physicalWidth
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001310")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001311")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003AD")]
	public private int virtualHeight
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600130E")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600130F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003AC")]
	public private int virtualWidth
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600130C")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600130D")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1C90280", Offset = "0x1C8F480", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600131D")]
	private static UIRAtlasAllocator() { }

	[Address(RVA = "0x1C902E0", Offset = "0x1C8F4E0", Length = "0x296")]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "AllocateRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "GetLog2OfNextPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AreaNode), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(AreaNode))]
	[Calls(Type = typeof(AreaNode), Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001319")]
	public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1) { }

	[Address(RVA = "0x1C8F870", Offset = "0x1C8EA70", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AreaNode), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(AreaNode))]
	[Calls(Type = typeof(AreaNode), Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600131C")]
	private void BuildAreas() { }

	[Address(RVA = "0x1C8F950", Offset = "0x1C8EB50", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Row), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001317")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1C8FAA0", Offset = "0x1C8ECA0", Length = "0x61")]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001316")]
	public override void Dispose() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001314")]
	protected bool get_disposed() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001309")]
	public int get_maxAtlasSize() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600130B")]
	public int get_maxImageHeight() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600130A")]
	public int get_maxImageWidth() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001312")]
	public int get_physicalHeight() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001310")]
	public int get_physicalWidth() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600130E")]
	public int get_virtualHeight() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600130C")]
	public int get_virtualWidth() { }

	[Address(RVA = "0x1C8FB10", Offset = "0x1C8ED10", Length = "0x16E")]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001318")]
	private static int GetLog2OfNextPower(int n) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001315")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001313")]
	private void set_physicalHeight(int value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001311")]
	private void set_physicalWidth(int value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600130F")]
	private void set_virtualHeight(int value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600130D")]
	private void set_virtualWidth(int value) { }

	[Address(RVA = "0x1C8FC80", Offset = "0x1C8EE80", Length = "0x386")]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "AllocateRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "GetLog2OfNextPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191B680")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191B5A0")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "TryPartitionArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AreaNode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600131A")]
	public bool TryAllocate(int width, int height, out RectInt location) { }

	[Address(RVA = "0x1C90010", Offset = "0x1C8F210", Length = "0x26A")]
	[CalledBy(Type = typeof(UIRAtlasAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Row), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AreaNode), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600131B")]
	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

}

