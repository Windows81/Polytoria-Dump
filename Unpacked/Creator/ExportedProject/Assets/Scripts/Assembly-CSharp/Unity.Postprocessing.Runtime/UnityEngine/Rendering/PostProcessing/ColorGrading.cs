namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", True)]
[Token(Token = "0x2000020")]
public sealed class ColorGrading : PostProcessEffectSettings
{
	[DisplayName("Mode")]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000060")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	public GradingModeParameter gradingMode; //Field offset: 0x30
	[DisplayName("Lookup Texture")]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000061")]
	[Tooltip("A custom 3D log-encoded texture.")]
	public TextureParameter externalLut; //Field offset: 0x38
	[DisplayName("Mode")]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000062")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	public TonemapperParameter tonemapper; //Field offset: 0x40
	[DisplayName("Toe Strength")]
	[FieldOffset(Offset = "0x48")]
	[Range(0, 1)]
	[Token(Token = "0x4000063")]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveToeStrength; //Field offset: 0x48
	[DisplayName("Toe Length")]
	[FieldOffset(Offset = "0x50")]
	[Range(0, 1)]
	[Token(Token = "0x4000064")]
	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	public FloatParameter toneCurveToeLength; //Field offset: 0x50
	[DisplayName("Shoulder Strength")]
	[FieldOffset(Offset = "0x58")]
	[Range(0, 1)]
	[Token(Token = "0x4000065")]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveShoulderStrength; //Field offset: 0x58
	[DisplayName("Shoulder Length")]
	[FieldOffset(Offset = "0x60")]
	[Min(0)]
	[Token(Token = "0x4000066")]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	public FloatParameter toneCurveShoulderLength; //Field offset: 0x60
	[DisplayName("Shoulder Angle")]
	[FieldOffset(Offset = "0x68")]
	[Range(0, 1)]
	[Token(Token = "0x4000067")]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	public FloatParameter toneCurveShoulderAngle; //Field offset: 0x68
	[DisplayName("Gamma")]
	[FieldOffset(Offset = "0x70")]
	[Min(0.001)]
	[Token(Token = "0x4000068")]
	[Tooltip("Applies a gamma function to the curve.")]
	public FloatParameter toneCurveGamma; //Field offset: 0x70
	[DisplayName("Lookup Texture")]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000069")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut; //Field offset: 0x78
	[DisplayName("Contribution")]
	[FieldOffset(Offset = "0x80")]
	[Range(0, 1)]
	[Token(Token = "0x400006A")]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	public FloatParameter ldrLutContribution; //Field offset: 0x80
	[DisplayName("Temperature")]
	[FieldOffset(Offset = "0x88")]
	[Range(-100, 100)]
	[Token(Token = "0x400006B")]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public FloatParameter temperature; //Field offset: 0x88
	[DisplayName("Tint")]
	[FieldOffset(Offset = "0x90")]
	[Range(-100, 100)]
	[Token(Token = "0x400006C")]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public FloatParameter tint; //Field offset: 0x90
	[ColorUsage(False, True)]
	[DisplayName("Color Filter")]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400006D")]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; //Field offset: 0x98
	[DisplayName("Hue Shift")]
	[FieldOffset(Offset = "0xA0")]
	[Range(-180, 180)]
	[Token(Token = "0x400006E")]
	[Tooltip("Shift the hue of all colors.")]
	public FloatParameter hueShift; //Field offset: 0xA0
	[DisplayName("Saturation")]
	[FieldOffset(Offset = "0xA8")]
	[Range(-100, 100)]
	[Token(Token = "0x400006F")]
	[Tooltip("Pushes the intensity of all colors.")]
	public FloatParameter saturation; //Field offset: 0xA8
	[DisplayName("Brightness")]
	[FieldOffset(Offset = "0xB0")]
	[Range(-100, 100)]
	[Token(Token = "0x4000070")]
	[Tooltip("Makes the image brighter or darker.")]
	public FloatParameter brightness; //Field offset: 0xB0
	[DisplayName("Post-exposure (EV)")]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000071")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; //Field offset: 0xB8
	[DisplayName("Contrast")]
	[FieldOffset(Offset = "0xC0")]
	[Range(-100, 100)]
	[Token(Token = "0x4000072")]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public FloatParameter contrast; //Field offset: 0xC0
	[DisplayName("Red")]
	[FieldOffset(Offset = "0xC8")]
	[Range(-200, 200)]
	[Token(Token = "0x4000073")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerRedOutRedIn; //Field offset: 0xC8
	[DisplayName("Green")]
	[FieldOffset(Offset = "0xD0")]
	[Range(-200, 200)]
	[Token(Token = "0x4000074")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerRedOutGreenIn; //Field offset: 0xD0
	[DisplayName("Blue")]
	[FieldOffset(Offset = "0xD8")]
	[Range(-200, 200)]
	[Token(Token = "0x4000075")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerRedOutBlueIn; //Field offset: 0xD8
	[DisplayName("Red")]
	[FieldOffset(Offset = "0xE0")]
	[Range(-200, 200)]
	[Token(Token = "0x4000076")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerGreenOutRedIn; //Field offset: 0xE0
	[DisplayName("Green")]
	[FieldOffset(Offset = "0xE8")]
	[Range(-200, 200)]
	[Token(Token = "0x4000077")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn; //Field offset: 0xE8
	[DisplayName("Blue")]
	[FieldOffset(Offset = "0xF0")]
	[Range(-200, 200)]
	[Token(Token = "0x4000078")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerGreenOutBlueIn; //Field offset: 0xF0
	[DisplayName("Red")]
	[FieldOffset(Offset = "0xF8")]
	[Range(-200, 200)]
	[Token(Token = "0x4000079")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerBlueOutRedIn; //Field offset: 0xF8
	[DisplayName("Green")]
	[FieldOffset(Offset = "0x100")]
	[Range(-200, 200)]
	[Token(Token = "0x400007A")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerBlueOutGreenIn; //Field offset: 0x100
	[DisplayName("Blue")]
	[FieldOffset(Offset = "0x108")]
	[Range(-200, 200)]
	[Token(Token = "0x400007B")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerBlueOutBlueIn; //Field offset: 0x108
	[DisplayName("Lift")]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400007C")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(Mode::Lift (1))]
	public Vector4Parameter lift; //Field offset: 0x110
	[DisplayName("Gamma")]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400007D")]
	[Tooltip("Power function that controls mid-range tones.")]
	[Trackball(Mode::Gamma (2))]
	public Vector4Parameter gamma; //Field offset: 0x118
	[DisplayName("Gain")]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400007E")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(Mode::Gain (3))]
	public Vector4Parameter gain; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400007F")]
	public SplineParameter masterCurve; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000080")]
	public SplineParameter redCurve; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000081")]
	public SplineParameter greenCurve; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000082")]
	public SplineParameter blueCurve; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000083")]
	public SplineParameter hueVsHueCurve; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000084")]
	public SplineParameter hueVsSatCurve; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000085")]
	public SplineParameter satVsSatCurve; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000086")]
	public SplineParameter lumVsSatCurve; //Field offset: 0x160

	[Address(RVA = "0x182FD80", Offset = "0x182EF80", Length = "0x1056")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Spline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(float), typeof(bool), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000030")]
	public ColorGrading() { }

	[Address(RVA = "0x182FD30", Offset = "0x182EF30", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600002F")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

