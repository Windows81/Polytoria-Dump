namespace UnityEngine.UIElements;

[Token(Token = "0x2000412")]
public struct TransformOrigin : IEquatable<TransformOrigin>
{
	[Token(Token = "0x2000413")]
	public class PropertyBag : ContainerPropertyBag<TransformOrigin>
	{
		[Token(Token = "0x2000414")]
		private class XProperty : Property<TransformOrigin, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D83")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D84")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000896")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F41")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000895")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F40")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B23460", Offset = "0x1B22660", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001F44")]
			public XProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F41")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F40")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1A16EE0", Offset = "0x1A160E0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F42")]
			public virtual Length GetValue(ref TransformOrigin container) { }

			[Address(RVA = "0x1B07720", Offset = "0x1B06920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F43")]
			public virtual void SetValue(ref TransformOrigin container, Length value) { }

		}

		[Token(Token = "0x2000415")]
		private class YProperty : Property<TransformOrigin, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D85")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D86")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000898")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F46")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000897")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F45")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B234F0", Offset = "0x1B226F0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001F49")]
			public YProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F46")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F45")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B234D0", Offset = "0x1B226D0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F47")]
			public virtual Length GetValue(ref TransformOrigin container) { }

			[Address(RVA = "0x1B234E0", Offset = "0x1B226E0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F48")]
			public virtual void SetValue(ref TransformOrigin container, Length value) { }

		}

		[Token(Token = "0x2000416")]
		private class ZProperty : Property<TransformOrigin, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D87")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D88")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700089A")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F4B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000899")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F4A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B23660", Offset = "0x1B22860", Length = "0x14B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001F4E")]
			public ZProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F4B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F4A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B235D0", Offset = "0x1B227D0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F4C")]
			public virtual float GetValue(ref TransformOrigin container) { }

			[Address(RVA = "0x1B235E0", Offset = "0x1B227E0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F4D")]
			public virtual void SetValue(ref TransformOrigin container, float value) { }

		}


		[Address(RVA = "0x1B11600", Offset = "0x1B10800", Length = "0x204")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001F3F")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D80")]
	private Length m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D81")]
	private Length m_Y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D82")]
	private float m_Z; //Field offset: 0x10

	[Token(Token = "0x17000892")]
	public Length x
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F33")]
		 get { } //Length: 4
		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F34")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000893")]
	public Length y
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F35")]
		 get { } //Length: 5
		[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F36")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000894")]
	public float z
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F37")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F38")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1B1C850", Offset = "0x1B1BA50", Length = "0xD")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin), typeof(float)}, ReturnType = typeof(TransformOrigin))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TransformOrigin))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001F30")]
	public TransformOrigin(Length x, Length y, float z) { }

	[Address(RVA = "0x1B1C860", Offset = "0x1B1BA60", Length = "0x6B")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001F31")]
	internal TransformOrigin(Vector3 vector) { }

	[Address(RVA = "0x1B1C420", Offset = "0x1B1B620", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F3B")]
	public override bool Equals(TransformOrigin other) { }

	[Address(RVA = "0x1B1C4C0", Offset = "0x1B1B6C0", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F3C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F33")]
	public Length get_x() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F35")]
	public Length get_y() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F37")]
	public float get_z() { }

	[Address(RVA = "0x1B1C5E0", Offset = "0x1B1B7E0", Length = "0x71")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F3D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B1C660", Offset = "0x1B1B860", Length = "0x7B")]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001F32")]
	public static TransformOrigin Initial() { }

	[Address(RVA = "0x1B1C8D0", Offset = "0x1B1BAD0", Length = "0xA0")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F39")]
	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	[Address(RVA = "0x1B1C970", Offset = "0x1B1BB70", Length = "0xA3")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F3A")]
	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F34")]
	public void set_x(Length value) { }

	[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F36")]
	public void set_y(Length value) { }

	[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F38")]
	public void set_z(float value) { }

	[Address(RVA = "0x1B1C6E0", Offset = "0x1B1B8E0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Length), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F3E")]
	public virtual string ToString() { }

}

