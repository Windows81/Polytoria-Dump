namespace UnityEngine.UIElements;

[Token(Token = "0x2000013")]
public struct BackgroundSize : IEquatable<BackgroundSize>
{
	[Token(Token = "0x2000014")]
	public class PropertyBag : ContainerPropertyBag<BackgroundSize>
	{
		[Token(Token = "0x2000015")]
		private class SizeTypeProperty : Property<BackgroundSize, BackgroundSizeType>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000027")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000028")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000014")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000067")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000013")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000066")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB5E00", Offset = "0x1AB5000", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600006A")]
			public SizeTypeProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000067")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000066")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1A189A0", Offset = "0x1A17BA0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000068")]
			public virtual BackgroundSizeType GetValue(ref BackgroundSize container) { }

			[Address(RVA = "0x1AB5DA0", Offset = "0x1AB4FA0", Length = "0x56")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[Token(Token = "0x6000069")]
			public virtual void SetValue(ref BackgroundSize container, BackgroundSizeType value) { }

		}

		[Token(Token = "0x2000016")]
		private class XProperty : Property<BackgroundSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000029")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400002A")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000016")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600006C")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000015")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600006B")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB7640", Offset = "0x1AB6840", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600006F")]
			public XProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600006C")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600006B")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB7620", Offset = "0x1AB6820", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x600006D")]
			public virtual Length GetValue(ref BackgroundSize container) { }

			[Address(RVA = "0x1AB7630", Offset = "0x1AB6830", Length = "0xB")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x600006E")]
			public virtual void SetValue(ref BackgroundSize container, Length value) { }

		}

		[Token(Token = "0x2000017")]
		private class YProperty : Property<BackgroundSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400002B")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400002C")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000018")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000071")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000017")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000070")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB7750", Offset = "0x1AB6950", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000074")]
			public YProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000071")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000070")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB7730", Offset = "0x1AB6930", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000072")]
			public virtual Length GetValue(ref BackgroundSize container) { }

			[Address(RVA = "0x1AB7740", Offset = "0x1AB6940", Length = "0xB")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000073")]
			public virtual void SetValue(ref BackgroundSize container, Length value) { }

		}


		[Address(RVA = "0x1AB5AE0", Offset = "0x1AB4CE0", Length = "0x204")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000065")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000024")]
	private BackgroundSizeType m_SizeType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000025")]
	private Length m_X; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000026")]
	private Length m_Y; //Field offset: 0xC

	[Token(Token = "0x17000010")]
	public BackgroundSizeType sizeType
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000056")]
		 get { } //Length: 5
		[Address(RVA = "0x1A932E0", Offset = "0x1A924E0", Length = "0x55")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000057")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000011")]
	public Length x
	{
		[Address(RVA = "0x1A93340", Offset = "0x1A92540", Length = "0x7")]
		[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 34)]
		[Token(Token = "0x6000058")]
		 get { } //Length: 7
		[Address(RVA = "0x1A93450", Offset = "0x1A92650", Length = "0xB")]
		[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000059")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000012")]
	public Length y
	{
		[Address(RVA = "0x1A93350", Offset = "0x1A92550", Length = "0x7")]
		[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Token(Token = "0x600005A")]
		 get { } //Length: 7
		[Address(RVA = "0x1A93460", Offset = "0x1A92660", Length = "0xB")]
		[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x600005B")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x1A932D0", Offset = "0x1A924D0", Length = "0xF")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600005C")]
	public BackgroundSize(Length sizeX, Length sizeY) { }

	[Address(RVA = "0x1A932E0", Offset = "0x1A924E0", Length = "0x55")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public BackgroundSize(BackgroundSizeType sizeType) { }

	[Address(RVA = "0x1A93030", Offset = "0x1A92230", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A93100", Offset = "0x1A92300", Length = "0x57")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000060")]
	public override bool Equals(BackgroundSize other) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public BackgroundSizeType get_sizeType() { }

	[Address(RVA = "0x1A93340", Offset = "0x1A92540", Length = "0x7")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 34)]
	[Token(Token = "0x6000058")]
	public Length get_x() { }

	[Address(RVA = "0x1A93350", Offset = "0x1A92550", Length = "0x7")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Token(Token = "0x600005A")]
	public Length get_y() { }

	[Address(RVA = "0x1A93160", Offset = "0x1A92360", Length = "0x4E")]
	[CalledBy(Type = typeof(VisualData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleBackgroundSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000061")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A931B0", Offset = "0x1A923B0", Length = "0x58")]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = "Percent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Token(Token = "0x600005E")]
	internal static BackgroundSize Initial() { }

	[Address(RVA = "0x1A93360", Offset = "0x1A92560", Length = "0x68")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData), typeof(VisualData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize), typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000062")]
	public static bool op_Equality(BackgroundSize style1, BackgroundSize style2) { }

	[Address(RVA = "0x1A933D0", Offset = "0x1A925D0", Length = "0x79")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000063")]
	public static bool op_Inequality(BackgroundSize style1, BackgroundSize style2) { }

	[Address(RVA = "0x1A932E0", Offset = "0x1A924E0", Length = "0x55")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public void set_sizeType(BackgroundSizeType value) { }

	[Address(RVA = "0x1A93450", Offset = "0x1A92650", Length = "0xB")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000059")]
	public void set_x(Length value) { }

	[Address(RVA = "0x1A93460", Offset = "0x1A92660", Length = "0xB")]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600005B")]
	public void set_y(Length value) { }

	[Address(RVA = "0x1A93210", Offset = "0x1A92410", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000064")]
	public virtual string ToString() { }

}

