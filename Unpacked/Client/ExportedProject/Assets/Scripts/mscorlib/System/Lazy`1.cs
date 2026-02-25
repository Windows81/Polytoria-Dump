namespace System;

[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView`1))]
[Token(Token = "0x2000109")]
public class Lazy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042C")]
	private LazyHelper _state; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042D")]
	private Func<T> _factory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042E")]
	private T _value; //Field offset: 0x0

	[Token(Token = "0x1700008D")]
	public bool IsValueCreated
	{
		[Address(RVA = "0xCE9C30", Offset = "0xCE8E30", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600082F")]
		 get { } //Length: 27
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x1700008E")]
	public T Value
	{
		[Address(RVA = "0xCE9C90", Offset = "0xCE8E90", Length = "0x1BC")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
		[CalledBy(Type = typeof(Lazy`1), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDED0")]
		[Calls(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDB60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDE20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDC60")]
		[Calls(Type = typeof(Lazy`1), Member = "ExecutionAndPublication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyHelper), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LazyHelper), Member = "ThrowException", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000830")]
		 get { } //Length: 444
	}

	[Address(RVA = "0xCE97B0", Offset = "0xCE89B0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000823")]
	public Lazy`1() { }

	[Address(RVA = "0xCE9B40", Offset = "0xCE8D40", Length = "0xE6")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000824")]
	public Lazy`1(Func<T> valueFactory) { }

	[Address(RVA = "0xCE9A50", Offset = "0xCE8C50", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000825")]
	private Lazy`1(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	[Address(RVA = "0xCE78B0", Offset = "0xCE6AB0", Length = "0x188")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDED0")]
	[Calls(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDE20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDC60")]
	[Calls(Type = typeof(Lazy`1), Member = "ExecutionAndPublication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyHelper), Member = "ThrowException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082D")]
	private T CreateValue() { }

	[Address(RVA = "0xCE7D50", Offset = "0xCE6F50", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(LazyHelper), Member = "CreateViaDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000822")]
	private static T CreateViaDefaultConstructor() { }

	[Address(RVA = "0xCE8210", Offset = "0xCE7410", Length = "0x121")]
	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CalledBy(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000828")]
	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) { }

	[Address(RVA = "0xCE9C30", Offset = "0xCE8E30", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600082F")]
	public bool get_IsValueCreated() { }

	[Address(RVA = "0xCE9C90", Offset = "0xCE8E90", Length = "0x1BC")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CalledBy(Type = typeof(Lazy`1), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDED0")]
	[Calls(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDE20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDC60")]
	[Calls(Type = typeof(Lazy`1), Member = "ExecutionAndPublication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyHelper), Member = "ThrowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000830")]
	public T get_Value() { }

	[Address(RVA = "0xCE8B90", Offset = "0xCE7D90", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000829")]
	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) { }

	[Address(RVA = "0xCE8420", Offset = "0xCE7620", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDE20")]
	[DeduplicatedMethod]
	[Token(Token = "0x600082A")]
	private void PublicationOnlyViaConstructor(LazyHelper initializer) { }

	[Address(RVA = "0xCE84E0", Offset = "0xCE76E0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDE20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDC60")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082B")]
	private void PublicationOnlyViaFactory(LazyHelper initializer) { }

	[Address(RVA = "0xCE87F0", Offset = "0xCE79F0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600082C")]
	private void PublicationOnlyWaitForOtherThreadToPublish() { }

	[Address(RVA = "0xCE8CE0", Offset = "0xCE7EE0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x600082E")]
	public virtual string ToString() { }

	[Address(RVA = "0xCE8F60", Offset = "0xCE8160", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000826")]
	private void ViaConstructor() { }

	[Address(RVA = "0xCE9220", Offset = "0xCE8420", Length = "0x11B")]
	[CalledBy(Type = typeof(Lazy`1), Member = "ExecutionAndPublication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CalledBy(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(LazyHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000827")]
	private void ViaFactory(LazyThreadSafetyMode mode) { }

}

