namespace UnityEngine.UIElements;

[Token(Token = "0x20002F8")]
public struct FontDefinition : IEquatable<FontDefinition>
{
	[Token(Token = "0x20002F9")]
	public class PropertyBag : ContainerPropertyBag<FontDefinition>
	{
		[Token(Token = "0x20002FB")]
		private class FontAssetProperty : Property<FontDefinition, FontAsset>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000C12")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000C13")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000452")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001541")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000451")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001540")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1ADA3C0", Offset = "0x1AD95C0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001544")]
			public FontAssetProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001541")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001540")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1ADA390", Offset = "0x1AD9590", Length = "0x7")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001542")]
			public virtual FontAsset GetValue(ref FontDefinition container) { }

			[Address(RVA = "0x1ADA3A0", Offset = "0x1AD95A0", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FontDefinition), Member = "set_fontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001543")]
			public virtual void SetValue(ref FontDefinition container, FontAsset value) { }

		}

		[Token(Token = "0x20002FA")]
		private class FontProperty : Property<FontDefinition, Font>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000C10")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000C11")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000450")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600153C")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700044F")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600153B")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1ADAB70", Offset = "0x1AD9D70", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600153F")]
			public FontProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600153C")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600153B")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1ADAB40", Offset = "0x1AD9D40", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600153D")]
			public virtual Font GetValue(ref FontDefinition container) { }

			[Address(RVA = "0x1ADAB50", Offset = "0x1AD9D50", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FontDefinition), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
			[Token(Token = "0x600153E")]
			public virtual void SetValue(ref FontDefinition container, Font value) { }

		}


		[Address(RVA = "0x1AE9040", Offset = "0x1AE8240", Length = "0x181")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600153A")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C0E")]
	private Font m_Font; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C0F")]
	private FontAsset m_FontAsset; //Field offset: 0x8

	[Token(Token = "0x1700044D")]
	public Font font
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x600152C")]
		 get { } //Length: 6
		[Address(RVA = "0x1ADAA50", Offset = "0x1AD9C50", Length = "0xE6")]
		[CalledBy(Type = "UnityEngine.UIElements.FontDefinition+PropertyBag+FontProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition&), typeof(Font)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600152D")]
		 set { } //Length: 230
	}

	[Token(Token = "0x1700044E")]
	public FontAsset fontAsset
	{
		[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x600152E")]
		 get { } //Length: 7
		[Address(RVA = "0x1ADA960", Offset = "0x1AD9B60", Length = "0xE7")]
		[CalledBy(Type = "UnityEngine.UIElements.FontDefinition+PropertyBag+FontAssetProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition&), typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600152F")]
		 set { } //Length: 231
	}

	[Address(RVA = "0x1ADA4E0", Offset = "0x1AD96E0", Length = "0x48")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001535")]
	public override bool Equals(FontDefinition other) { }

	[Address(RVA = "0x1ADA430", Offset = "0x1AD9630", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001536")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1ADA530", Offset = "0x1AD9730", Length = "0x38")]
	[CalledBy(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001530")]
	public static FontDefinition FromFont(Font f) { }

	[Address(RVA = "0x1ADA570", Offset = "0x1AD9770", Length = "0x149")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleValueCollection), Member = "GetStyleFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFontDefinition))]
	[CalledBy(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001532")]
	internal static FontDefinition FromObject(object obj) { }

	[Address(RVA = "0x1ADA6C0", Offset = "0x1AD98C0", Length = "0x38")]
	[CalledBy(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset), typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001531")]
	public static FontDefinition FromSDFFont(FontAsset f) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x600152C")]
	public Font get_font() { }

	[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x600152E")]
	public FontAsset get_fontAsset() { }

	[Address(RVA = "0x1ADA700", Offset = "0x1AD9900", Length = "0xEC")]
	[CalledBy(Type = typeof(InheritedData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleFontDefinition), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001537")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1ADA7F0", Offset = "0x1AD99F0", Length = "0x8E")]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001533")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x1ADA4E0", Offset = "0x1AD96E0", Length = "0x48")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001538")]
	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	[Address(RVA = "0x1ADA910", Offset = "0x1AD9B10", Length = "0x4C")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001539")]
	public static bool op_Inequality(FontDefinition left, FontDefinition right) { }

	[Address(RVA = "0x1ADAA50", Offset = "0x1AD9C50", Length = "0xE6")]
	[CalledBy(Type = "UnityEngine.UIElements.FontDefinition+PropertyBag+FontProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition&), typeof(Font)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600152D")]
	public void set_font(Font value) { }

	[Address(RVA = "0x1ADA960", Offset = "0x1AD9B60", Length = "0xE7")]
	[CalledBy(Type = "UnityEngine.UIElements.FontDefinition+PropertyBag+FontAssetProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition&), typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600152F")]
	public void set_fontAsset(FontAsset value) { }

	[Address(RVA = "0x1ADA880", Offset = "0x1AD9A80", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001534")]
	public virtual string ToString() { }

}

