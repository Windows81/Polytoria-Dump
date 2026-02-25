namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Token(Token = "0x20005F4")]
internal class LowLevelList
{
	[Token(Token = "0x400188A")]
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001887")]
	protected T[] _items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001888")]
	protected int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001889")]
	protected int _version; //Field offset: 0x0

	[Token(Token = "0x170006DD")]
	public int Capacity
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB6")]
		 get { } //Length: 26
		[Address(RVA = "0xE07600", Offset = "0xE06800", Length = "0x140")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB7")]
		 set { } //Length: 320
	}

	[Token(Token = "0x170006DE")]
	public override int Count
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006DF")]
	public override T Item
	{
		[Address(RVA = "0xE074A0", Offset = "0xE066A0", Length = "0x6B")]
		[CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(AggregateException))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB9")]
		 get { } //Length: 107
		[Address(RVA = "0xE078C0", Offset = "0xE06AC0", Length = "0x85")]
		[CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BBA")]
		 set { } //Length: 133
	}

	[Address(RVA = "0xCFCF00", Offset = "0xCFC100", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC8")]
	private static LowLevelList`1() { }

	[Address(RVA = "0xCFD0C0", Offset = "0xCFC2C0", Length = "0x89")]
	[CallerCount(Count = 884)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB4")]
	public LowLevelList`1() { }

	[Address(RVA = "0xE07390", Offset = "0xE06590", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB5")]
	public LowLevelList`1(int capacity) { }

	[Address(RVA = "0xE05490", Offset = "0xE04690", Length = "0x80")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ProcessChildCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddTaskContinuationComplex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(LowLevelList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBB")]
	public override void Add(T item) { }

	[Address(RVA = "0xE05450", Offset = "0xE04650", Length = "0x1A")]
	[CalledBy(Type = "System.Threading.Tasks.Task+WhenAllPromise", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LowLevelList`1), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBD")]
	public void AddRange(IEnumerable<T> collection) { }

	[Address(RVA = "0xE05690", Offset = "0xE04890", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBE")]
	public override void Clear() { }

	[Address(RVA = "0xE056D0", Offset = "0xE048D0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBF")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xCF6E50", Offset = "0xCF6050", Length = "0x2A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC0")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xE05940", Offset = "0xE04B40", Length = "0x170")]
	[CalledBy(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LowLevelList`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LowLevelList`1), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBC")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB6")]
	public int get_Capacity() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB8")]
	public override int get_Count() { }

	[Address(RVA = "0xE074A0", Offset = "0xE066A0", Length = "0x6B")]
	[CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(AggregateException))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB9")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xE05B20", Offset = "0xE04D20", Length = "0x2D")]
	[CalledBy(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC1")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xE06650", Offset = "0xE05850", Length = "0x106")]
	[CalledBy(Type = typeof(Task), Member = "AddTaskContinuationComplex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LowLevelList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC2")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xE06170", Offset = "0xE05370", Length = "0x4D7")]
	[CalledBy(Type = typeof(LowLevelList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(LowLevelList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC3")]
	public void InsertRange(int index, IEnumerable<T> collection) { }

	[Address(RVA = "0xE070F0", Offset = "0xE062F0", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC4")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xE06940", Offset = "0xE05B40", Length = "0x1C8")]
	[CalledBy(Type = typeof(Task), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddTaskContinuationComplex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC5")]
	public int RemoveAll(Predicate<T> match) { }

	[Address(RVA = "0xE06E60", Offset = "0xE06060", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC6")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xE07600", Offset = "0xE06800", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB7")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xE078C0", Offset = "0xE06AC0", Length = "0x85")]
	[CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBA")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xE07320", Offset = "0xE06520", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC7")]
	public T[] ToArray() { }

}

