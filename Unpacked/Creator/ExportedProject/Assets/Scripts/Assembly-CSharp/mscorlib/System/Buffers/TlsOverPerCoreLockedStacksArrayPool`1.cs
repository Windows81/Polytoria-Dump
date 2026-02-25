namespace System.Buffers;

[Token(Token = "0x2000610")]
internal sealed class TlsOverPerCoreLockedStacksArrayPool : ArrayPool<T>
{
	[Token(Token = "0x2000613")]
	private sealed class LockedStack
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A7")]
		private readonly T[][] _arrays; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A8")]
		private int _count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A9")]
		private uint _firstStackItemMS; //Field offset: 0x0

		[Address(RVA = "0xE03290", Offset = "0xE02490", Length = "0x55")]
		[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C67")]
		public LockedStack() { }

		[Address(RVA = "0xE02D70", Offset = "0xE01F70", Length = "0x25D")]
		[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(Int32[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C66")]
		public void Trim(uint tickCount, int id, MemoryPressure<T> pressure, int bucketSize) { }

		[Address(RVA = "0xE02FD0", Offset = "0xE021D0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C65")]
		public T[] TryPop() { }

		[Address(RVA = "0xE03060", Offset = "0xE02260", Length = "0xFC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C64")]
		public bool TryPush(T[] array) { }

	}

	[Token(Token = "0x2000611")]
	private enum MemoryPressure
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	[Token(Token = "0x2000612")]
	private sealed class PerCoreLockedStacks
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A6")]
		private readonly LockedStack<T>[] _perCoreStacks; //Field offset: 0x0

		[Address(RVA = "0xE680D0", Offset = "0xE672D0", Length = "0x14E")]
		[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "CreatePerCoreLockedStacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+PerCoreLockedStacks<T>")]
		[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C60")]
		public PerCoreLockedStacks() { }

		[Address(RVA = "0xE67000", Offset = "0xE66200", Length = "0xD4")]
		[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C63")]
		public bool Trim(uint tickCount, int id, MemoryPressure<T> pressure, Int32[] bucketSizes) { }

		[Address(RVA = "0xE67340", Offset = "0xE66540", Length = "0x163")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C62")]
		public T[] TryPop() { }

		[Address(RVA = "0xE67950", Offset = "0xE66B50", Length = "0x1BC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C61")]
		public void TryPush(T[] array) { }

	}

	[ThreadStatic]
	[Token(Token = "0x400189E")]
	private static T[][] t_tlsBuckets; //Field offset: 0xFFFFFFFF
	[Token(Token = "0x40018A0")]
	private static readonly bool s_trimBuffers; //Field offset: 0x0
	[Token(Token = "0x40018A1")]
	private static readonly ConditionalWeakTable<T[][], Object> s_allTlsBuckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189C")]
	private readonly Int32[] _bucketArraySizes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189D")]
	private readonly PerCoreLockedStacks<T>[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189F")]
	private int _callbackCreated; //Field offset: 0x0

	[Token(Token = "0x170006EA")]
	private int Id
	{
		[Address(RVA = "0x1002460", Offset = "0x1001660", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C58")]
		private get { } //Length: 38
	}

	[Address(RVA = "0x1001B30", Offset = "0x1000D30", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C5F")]
	private static TlsOverPerCoreLockedStacksArrayPool`1() { }

	[Address(RVA = "0x1002340", Offset = "0x1001540", Length = "0x118")]
	[CalledBy(Type = typeof(ArrayPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C56")]
	public TlsOverPerCoreLockedStacksArrayPool`1() { }

	[Address(RVA = "0xFFB1D0", Offset = "0xFFA3D0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PerCoreLockedStacks), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C57")]
	private PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }

	[Address(RVA = "0xFFB760", Offset = "0xFFA960", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C5C")]
	private static bool Gen2GcCallbackFunc(object target) { }

	[Address(RVA = "0x1002460", Offset = "0x1001660", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C58")]
	private int get_Id() { }

	[Address(RVA = "0xFFBC60", Offset = "0xFFAE60", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "GetMemoryInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&), typeof(UInt64&), typeof(UInt32&), typeof(UIntPtr&), typeof(UIntPtr&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C5D")]
	private static MemoryPressure<T> GetMemoryPressure() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C5E")]
	private static bool GetTrimBuffers() { }

	[Address(RVA = "0xFFC800", Offset = "0xFFBA00", Length = "0x55F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferAllocated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BufferAllocatedReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferRented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Utilities), Member = "SelectBucketIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C59")]
	public virtual T[] Rent(int minimumLength) { }

	[Address(RVA = "0xFFD820", Offset = "0xFFCA20", Length = "0x548")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180FE9C80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Gen2GcCallback), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Boolean>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferReturned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(PerCoreLockedStacks), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utilities), Member = "SelectBucketIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C5A")]
	public virtual void Return(T[] array, bool clearArray = false) { }

	[Address(RVA = "0xFFF2A0", Offset = "0xFFE4A0", Length = "0x812")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Gen2GcCallbackFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimPoll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PerCoreLockedStacks), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GC), Member = "GetMemoryInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&), typeof(UInt64&), typeof(UInt32&), typeof(UIntPtr&), typeof(UIntPtr&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C5B")]
	public bool Trim() { }

}

