namespace HSVPicker;

[Token(Token = "0x2000018")]
public static class HSVUtil
{

	[Address(RVA = "0x1098840", Offset = "0x1097A40", Length = "0x140")]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_H", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_S", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_V", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "HSVChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "AssignColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorValues), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorSliderImage), Member = "RegenerateTexture", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "SliderChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "RegenerateSVTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(double), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008A")]
	public static Color ConvertHsvToRgb(double h, double s, double v, float alpha) { }

	[Address(RVA = "0x1098980", Offset = "0x1097B80", Length = "0x1F2")]
	[CalledBy(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HSVUtil), Member = "ConvertRgbToHsv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(HsvColor))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(double), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000089")]
	public static HsvColor ConvertRgbToHsv(double r, double b, double g) { }

	[Address(RVA = "0x1098B80", Offset = "0x1097D80", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertRgbToHsv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(HsvColor))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000088")]
	public static HsvColor ConvertRgbToHsv(Color color) { }

}

