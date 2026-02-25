namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200050F")]
public struct BindingId : IEquatable<BindingId>
{
	[Token(Token = "0x40010C0")]
	public static readonly BindingId Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40010C1")]
	private readonly PropertyPath m_PropertyPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40010C2")]
	private readonly string m_Path; //Field offset: 0x90

	[Address(RVA = "0x1B5F640", Offset = "0x1B5E840", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600250F")]
	private static BindingId() { }

	[Address(RVA = "0x1B5F6B0", Offset = "0x1B5E8B0", Length = "0xD9")]
	[CalledBy(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002503")]
	public BindingId(string path) { }

	[Address(RVA = "0x1B5F790", Offset = "0x1B5E990", Length = "0xB3")]
	[CalledBy(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyPath), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6002504")]
	public BindingId(in PropertyPath path) { }

	[Address(RVA = "0x1B5F300", Offset = "0x1B5E500", Length = "0x119")]
	[CalledBy(Type = typeof(BindingId), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600250A")]
	public override bool Equals(BindingId other) { }

	[Address(RVA = "0x1B5F420", Offset = "0x1B5E620", Length = "0x204")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600250B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B5F630", Offset = "0x1B5E830", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600250C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B5F850", Offset = "0x1B5EA50", Length = "0xCF")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "OnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyChangedEvent), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+IgnoreUIChangesData", Member = "ShouldIgnoreChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Binding), typeof(BindingId)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600250D")]
	public static bool op_Equality(in BindingId lhs, in BindingId rhs) { }

	[Address(RVA = "0x1B0C5A0", Offset = "0x1B0B7A0", Length = "0x50")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002505")]
	public static PropertyPath op_Implicit(in BindingId vep) { }

	[Address(RVA = "0x19AA800", Offset = "0x19A9A00", Length = "0xA")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002506")]
	public static string op_Implicit(in BindingId vep) { }

	[Address(RVA = "0x1B5FA20", Offset = "0x1B5EC20", Length = "0xF7")]
	[CallerCount(Count = 209)]
	[Calls(Type = typeof(BindingId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002507")]
	public static BindingId op_Implicit(string name) { }

	[Address(RVA = "0x1B5F920", Offset = "0x1B5EB20", Length = "0xF7")]
	[CalledBy(Type = typeof(DataBinding), Member = "UpdateSource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingInfo), Member = "FromRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(PropertyPath&), typeof(Binding)}, ReturnType = typeof(BindingInfo))]
	[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BindingId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002508")]
	public static BindingId op_Implicit(in PropertyPath path) { }

	[Address(RVA = "0x1B5FB20", Offset = "0x1B5ED20", Length = "0x136")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "TryGetBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600250E")]
	public static bool op_Inequality(in BindingId lhs, in BindingId rhs) { }

	[Address(RVA = "0x19AA800", Offset = "0x19A9A00", Length = "0xA")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002509")]
	public virtual string ToString() { }

}

