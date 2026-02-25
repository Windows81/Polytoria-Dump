namespace RLD;

[Token(Token = "0x20002B2")]
public class ObjectSelectionDuplicationResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A76")]
	private List<GameObject> _duplicateParents; //Field offset: 0x10

	[Token(Token = "0x17000883")]
	public List<GameObject> DuplicateParents
	{
		[Address(RVA = "0x3EA330", Offset = "0x3E9530", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001995")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000884")]
	public int NumDuplicateParents
	{
		[Address(RVA = "0x3EA3A0", Offset = "0x3E95A0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001996")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x3EA2A0", Offset = "0x3E94A0", Length = "0x87")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Duplicate", ReturnType = typeof(ObjectSelectionDuplicationResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001997")]
	public ObjectSelectionDuplicationResult(List<GameObject> duplicatedParents) { }

	[Address(RVA = "0x3EA330", Offset = "0x3E9530", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001995")]
	public List<GameObject> get_DuplicateParents() { }

	[Address(RVA = "0x3EA3A0", Offset = "0x3E95A0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001996")]
	public int get_NumDuplicateParents() { }

	[Address(RVA = "0x3EA240", Offset = "0x3E9440", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001998")]
	public GameObject GetParentByIndex(int index) { }

}

