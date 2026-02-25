namespace UnityEngine.UI.ProceduralImage;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000447")]
public class ModifierID : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001236")]
	private string name; //Field offset: 0x10

	[Token(Token = "0x17000D29")]
	public string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D1D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D1C")]
	public ModifierID(string name) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D1D")]
	public string get_Name() { }

}

