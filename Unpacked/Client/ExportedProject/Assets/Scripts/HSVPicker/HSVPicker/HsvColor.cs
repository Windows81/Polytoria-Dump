namespace HSVPicker;

[Token(Token = "0x2000019")]
public struct HsvColor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000062")]
	public double H; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000063")]
	public double S; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000064")]
	public double V; //Field offset: 0x10

	[Token(Token = "0x17000017")]
	public float normalizedH
	{
		[Address(RVA = "0x1099470", Offset = "0x1098670", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008B")]
		 get { } //Length: 17
		[Address(RVA = "0x10994B0", Offset = "0x10986B0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008C")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000018")]
	public float normalizedS
	{
		[Address(RVA = "0x1099490", Offset = "0x1098690", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008D")]
		 get { } //Length: 10
		[Address(RVA = "0x10994D0", Offset = "0x10986D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000019")]
	public float normalizedV
	{
		[Address(RVA = "0x10994A0", Offset = "0x10986A0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008F")]
		 get { } //Length: 10
		[Address(RVA = "0x10994E0", Offset = "0x10986E0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000090")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1099460", Offset = "0x1098660", Length = "0xF")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	public HsvColor(double h, double s, double v) { }

	[Address(RVA = "0x1099470", Offset = "0x1098670", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008B")]
	public float get_normalizedH() { }

	[Address(RVA = "0x1099490", Offset = "0x1098690", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008D")]
	public float get_normalizedS() { }

	[Address(RVA = "0x10994A0", Offset = "0x10986A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008F")]
	public float get_normalizedV() { }

	[Address(RVA = "0x10994B0", Offset = "0x10986B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008C")]
	public void set_normalizedH(float value) { }

	[Address(RVA = "0x10994D0", Offset = "0x10986D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008E")]
	public void set_normalizedS(float value) { }

	[Address(RVA = "0x10994E0", Offset = "0x10986E0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000090")]
	public void set_normalizedV(float value) { }

	[Address(RVA = "0x10992D0", Offset = "0x10984D0", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000092")]
	public virtual string ToString() { }

}

