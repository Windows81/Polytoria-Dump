namespace UnityEngine.UIElements;

[Token(Token = "0x20003E7")]
public struct Length : IEquatable<Length>
{
	[Token(Token = "0x20003E9")]
	public class PropertyBag : ContainerPropertyBag<Length>
	{
		[Token(Token = "0x20003EB")]
		private class UnitProperty : Property<Length, LengthUnit>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D37")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D38")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000857")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DC4")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000856")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DC3")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B1DD40", Offset = "0x1B1CF40", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001DC7")]
			public UnitProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DC4")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DC3")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB7720", Offset = "0x1AB6920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DC5")]
			public virtual LengthUnit GetValue(ref Length container) { }

			[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DC6")]
			public virtual void SetValue(ref Length container, LengthUnit value) { }

		}

		[Token(Token = "0x20003EA")]
		private class ValueProperty : Property<Length, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D35")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D36")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000855")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DBF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000854")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DBE")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B1FDE0", Offset = "0x1B1EFE0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001DC2")]
			public ValueProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DBF")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DBE")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1A13380", Offset = "0x1A12580", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DC0")]
			public virtual float GetValue(ref Length container) { }

			[Address(RVA = "0x1B1FDB0", Offset = "0x1B1EFB0", Length = "0x24")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001DC1")]
			public virtual void SetValue(ref Length container, float value) { }

		}


		[Address(RVA = "0x1B11470", Offset = "0x1B10670", Length = "0x181")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001DBD")]
		public PropertyBag() { }

	}

	[Token(Token = "0x20003E8")]
	private enum Unit
	{
		Pixel = 0,
		Percent = 1,
		Auto = 2,
		None = 3,
	}

	[Token(Token = "0x4000D2D")]
	internal const float k_MaxValue = 8388608; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000D2E")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000D2F")]
	private Unit m_Unit; //Field offset: 0x4

	[Token(Token = "0x17000853")]
	public LengthUnit unit
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DAF")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DB0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000852")]
	public float value
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DAD")]
		 get { } //Length: 5
		[Address(RVA = "0x1B105F0", Offset = "0x1B0F7F0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001DAE")]
		 set { } //Length: 36
	}

	[Address(RVA = "0x1B10580", Offset = "0x1B0F780", Length = "0x2B")]
	[CalledBy(Type = typeof(BackgroundPosition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPositionKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BackgroundPosition), Member = "Initial", ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ResolveUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(BackgroundRepeat), typeof(BackgroundSize), typeof(Boolean&)}, ReturnType = typeof(ScaleMode))]
	[CalledBy(Type = "UnityEngine.UIElements.BackgroundSize+PropertyBag+SizeTypeProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSizeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BackgroundSize), Member = "set_sizeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSizeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BackgroundSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSizeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "FinalizeApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Token(Token = "0x6001DB3")]
	public Length(float value) { }

	[Address(RVA = "0x1B10550", Offset = "0x1B0F750", Length = "0x28")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB4")]
	public Length(float value, LengthUnit unit) { }

	[Address(RVA = "0x1B10550", Offset = "0x1B0F750", Length = "0x28")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB5")]
	private Length(float value, Unit unit) { }

	[Address(RVA = "0x1B102C0", Offset = "0x1B0F4C0", Length = "0x18")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileFlexShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x6001DAB")]
	public static Length Auto() { }

	[Address(RVA = "0x1B102E0", Offset = "0x1B0F4E0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DBA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1AD2A90", Offset = "0x1AD1C90", Length = "0x2D")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB9")]
	public override bool Equals(Length other) { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DAF")]
	public LengthUnit get_unit() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DAD")]
	public float get_value() { }

	[Address(RVA = "0x1AD2AC0", Offset = "0x1AD1CC0", Length = "0x1F")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DBB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B10390", Offset = "0x1B0F590", Length = "0x8")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveLengthValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(bool)}, ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheetUtility), Member = "ToDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(Dimension))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DB1")]
	public bool IsAuto() { }

	[Address(RVA = "0x1B103A0", Offset = "0x1B0F5A0", Length = "0x8")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveLengthValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(bool)}, ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheetUtility), Member = "ToDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(Dimension))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DB2")]
	public bool IsNone() { }

	[Address(RVA = "0x1B103B0", Offset = "0x1B0F5B0", Length = "0x18")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x6001DAC")]
	public static Length None() { }

	[Address(RVA = "0x1AD2D40", Offset = "0x1AD1F40", Length = "0x2A")]
	[CallerCount(Count = 34)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB7")]
	public static bool op_Equality(Length lhs, Length rhs) { }

	[Address(RVA = "0x1B105B0", Offset = "0x1B0F7B0", Length = "0x31")]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextAutoSize), Member = "None", ReturnType = typeof(TextAutoSize))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 58)]
	[Token(Token = "0x6001DB6")]
	public static Length op_Implicit(float value) { }

	[Address(RVA = "0x1AD2D90", Offset = "0x1AD1F90", Length = "0x2A")]
	[CallerCount(Count = 57)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB8")]
	public static bool op_Inequality(Length lhs, Length rhs) { }

	[Address(RVA = "0x1B103D0", Offset = "0x1B0F5D0", Length = "0x31")]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ResolveUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(BackgroundRepeat), typeof(BackgroundSize), typeof(Boolean&)}, ReturnType = typeof(ScaleMode))]
	[CalledBy(Type = typeof(BackgroundSize), Member = "Initial", ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileFlexShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TransformOrigin))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOriginEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(Length))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x6001DAA")]
	public static Length Percent(float value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB0")]
	public void set_unit(LengthUnit value) { }

	[Address(RVA = "0x1B105F0", Offset = "0x1B0F7F0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001DAE")]
	public void set_value(float value) { }

	[Address(RVA = "0x1B10410", Offset = "0x1B0F610", Length = "0x136")]
	[CalledBy(Type = typeof(TransformOrigin), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Translate), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001DBC")]
	public virtual string ToString() { }

}

