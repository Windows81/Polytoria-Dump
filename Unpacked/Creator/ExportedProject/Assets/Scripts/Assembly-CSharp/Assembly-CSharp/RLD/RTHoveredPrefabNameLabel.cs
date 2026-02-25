namespace RLD;

[Token(Token = "0x20001E4")]
public class RTHoveredPrefabNameLabel : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000768")]
	private Text _label; //Field offset: 0x20

	[Token(Token = "0x170005E4")]
	public string PrefabName
	{
		[Address(RVA = "0x580F40", Offset = "0x580140", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60012B8")]
		 get { } //Length: 42
		[Address(RVA = "0x580F70", Offset = "0x580170", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60012B9")]
		 set { } //Length: 52
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012BB")]
	public RTHoveredPrefabNameLabel() { }

	[Address(RVA = "0x580EF0", Offset = "0x5800F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60012BA")]
	private void Awake() { }

	[Address(RVA = "0x580F40", Offset = "0x580140", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B8")]
	public string get_PrefabName() { }

	[Address(RVA = "0x580F70", Offset = "0x580170", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B9")]
	public void set_PrefabName(string value) { }

}

