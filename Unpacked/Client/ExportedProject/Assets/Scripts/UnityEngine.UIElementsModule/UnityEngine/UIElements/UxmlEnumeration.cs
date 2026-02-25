namespace UnityEngine.UIElements;

[Token(Token = "0x20004ED")]
public class UxmlEnumeration : UxmlTypeRestriction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400102E")]
	private List<String> m_Values; //Field offset: 0x10

	[Token(Token = "0x17000981")]
	public IEnumerable<String> values
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002454")]
		 get { } //Length: 7
		[Address(RVA = "0x1B50FD0", Offset = "0x1B501D0", Length = "0x55")]
		[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002455")]
		 set { } //Length: 85
	}

	[Address(RVA = "0x1B50F50", Offset = "0x1B50150", Length = "0x77")]
	[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002457")]
	public UxmlEnumeration() { }

	[Address(RVA = "0x1B50DF0", Offset = "0x1B4FFF0", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002456")]
	public virtual bool Equals(UxmlTypeRestriction other) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002454")]
	public IEnumerable<String> get_values() { }

	[Address(RVA = "0x1B50FD0", Offset = "0x1B501D0", Length = "0x55")]
	[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002455")]
	public void set_values(IEnumerable<String> value) { }

}

