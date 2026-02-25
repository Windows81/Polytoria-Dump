namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A6")]
public class ImageSkyProxy : SkyBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF0")]
	private readonly ImageSky imageSky; //Field offset: 0x20

	[Token(Token = "0x17000BA1")]
	public int BackId
	{
		[Address(RVA = "0x4A4670", Offset = "0x4A3870", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002753")]
		 get { } //Length: 29
		[Address(RVA = "0x4A4730", Offset = "0x4A3930", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageSky), Member = "set_BackId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002754")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B9D")]
	public int BottomId
	{
		[Address(RVA = "0x4A4690", Offset = "0x4A3890", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600274B")]
		 get { } //Length: 29
		[Address(RVA = "0x4A4750", Offset = "0x4A3950", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageSky), Member = "set_BottomId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600274C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BA0")]
	public int FrontId
	{
		[Address(RVA = "0x4A46B0", Offset = "0x4A38B0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002751")]
		 get { } //Length: 29
		[Address(RVA = "0x4A4770", Offset = "0x4A3970", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageSky), Member = "set_FrontId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002752")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B9E")]
	public int LeftId
	{
		[Address(RVA = "0x4A46D0", Offset = "0x4A38D0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600274D")]
		 get { } //Length: 29
		[Address(RVA = "0x4A4790", Offset = "0x4A3990", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageSky), Member = "set_LeftId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600274E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B9F")]
	public int RightId
	{
		[Address(RVA = "0x4A46F0", Offset = "0x4A38F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600274F")]
		 get { } //Length: 29
		[Address(RVA = "0x4A47B0", Offset = "0x4A39B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageSky), Member = "set_RightId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002750")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B9C")]
	public int TopId
	{
		[Address(RVA = "0x4A4710", Offset = "0x4A3910", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002749")]
		 get { } //Length: 29
		[Address(RVA = "0x4A47D0", Offset = "0x4A39D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageSky), Member = "set_TopId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600274A")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002748")]
	public ImageSkyProxy(ImageSky target) { }

	[Address(RVA = "0x4A4670", Offset = "0x4A3870", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002753")]
	public int get_BackId() { }

	[Address(RVA = "0x4A4690", Offset = "0x4A3890", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600274B")]
	public int get_BottomId() { }

	[Address(RVA = "0x4A46B0", Offset = "0x4A38B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002751")]
	public int get_FrontId() { }

	[Address(RVA = "0x4A46D0", Offset = "0x4A38D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600274D")]
	public int get_LeftId() { }

	[Address(RVA = "0x4A46F0", Offset = "0x4A38F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600274F")]
	public int get_RightId() { }

	[Address(RVA = "0x4A4710", Offset = "0x4A3910", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002749")]
	public int get_TopId() { }

	[Address(RVA = "0x4A4730", Offset = "0x4A3930", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageSky), Member = "set_BackId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002754")]
	public void set_BackId(int value) { }

	[Address(RVA = "0x4A4750", Offset = "0x4A3950", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageSky), Member = "set_BottomId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600274C")]
	public void set_BottomId(int value) { }

	[Address(RVA = "0x4A4770", Offset = "0x4A3970", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageSky), Member = "set_FrontId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002752")]
	public void set_FrontId(int value) { }

	[Address(RVA = "0x4A4790", Offset = "0x4A3990", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageSky), Member = "set_LeftId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600274E")]
	public void set_LeftId(int value) { }

	[Address(RVA = "0x4A47B0", Offset = "0x4A39B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageSky), Member = "set_RightId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002750")]
	public void set_RightId(int value) { }

	[Address(RVA = "0x4A47D0", Offset = "0x4A39D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageSky), Member = "set_TopId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600274A")]
	public void set_TopId(int value) { }

}

