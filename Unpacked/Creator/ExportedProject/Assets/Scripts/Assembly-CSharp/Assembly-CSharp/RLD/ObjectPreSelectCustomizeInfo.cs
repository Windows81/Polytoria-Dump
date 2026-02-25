namespace RLD;

[Token(Token = "0x200029E")]
public class ObjectPreSelectCustomizeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A1D")]
	private List<GameObject> _toBeSelected; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A1E")]
	private ObjectSelectReason _selectRason; //Field offset: 0x18

	[Token(Token = "0x17000845")]
	public ObjectSelectReason SelectReason
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001919")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000847")]
	public List<GameObject> ToBeSelected
	{
		[Address(RVA = "0x3E8DD0", Offset = "0x3E7FD0", Length = "0x68")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x600191B")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000846")]
	public int ToBeSelectedCount
	{
		[Address(RVA = "0x3E8D90", Offset = "0x3E7F90", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600191A")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x3E8CF0", Offset = "0x3E7EF0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600191C")]
	public ObjectPreSelectCustomizeInfo(List<GameObject> toBeSelected, ObjectSelectReason selectReason) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001919")]
	public ObjectSelectReason get_SelectReason() { }

	[Address(RVA = "0x3E8DD0", Offset = "0x3E7FD0", Length = "0x68")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600191B")]
	public List<GameObject> get_ToBeSelected() { }

	[Address(RVA = "0x3E8D90", Offset = "0x3E7F90", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600191A")]
	public int get_ToBeSelectedCount() { }

	[Address(RVA = "0x3E8A70", Offset = "0x3E7C70", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600191E")]
	public void IgnoreThese(IEnumerable<GameObject> toBeIgnored) { }

	[Address(RVA = "0x3E8C50", Offset = "0x3E7E50", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600191D")]
	public void SelectThese(IEnumerable<GameObject> toBeSelected) { }

}

