namespace UnityEngine.UIElements;

[Token(Token = "0x2000417")]
public struct Translate : IEquatable<Translate>
{
	[Token(Token = "0x2000418")]
	public class PropertyBag : ContainerPropertyBag<Translate>
	{
		[Token(Token = "0x2000419")]
		private class XProperty : Property<Translate, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D8D")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D8E")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700089F")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F61")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700089E")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F60")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B233F0", Offset = "0x1B225F0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001F64")]
			public XProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F61")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F60")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1A16EE0", Offset = "0x1A160E0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F62")]
			public virtual Length GetValue(ref Translate container) { }

			[Address(RVA = "0x1B07720", Offset = "0x1B06920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F63")]
			public virtual void SetValue(ref Translate container, Length value) { }

		}

		[Token(Token = "0x200041A")]
		private class YProperty : Property<Translate, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D8F")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D90")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008A1")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F66")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008A0")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F65")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B23560", Offset = "0x1B22760", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001F69")]
			public YProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F66")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F65")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B234D0", Offset = "0x1B226D0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F67")]
			public virtual Length GetValue(ref Translate container) { }

			[Address(RVA = "0x1B234E0", Offset = "0x1B226E0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F68")]
			public virtual void SetValue(ref Translate container, Length value) { }

		}

		[Token(Token = "0x200041B")]
		private class ZProperty : Property<Translate, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D91")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D92")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008A3")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F6B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008A2")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001F6A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B235F0", Offset = "0x1B227F0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001F6E")]
			public ZProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F6B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F6A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B235D0", Offset = "0x1B227D0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F6C")]
			public virtual float GetValue(ref Translate container) { }

			[Address(RVA = "0x1B235E0", Offset = "0x1B227E0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F6D")]
			public virtual void SetValue(ref Translate container, float value) { }

		}


		[Address(RVA = "0x1B11810", Offset = "0x1B10A10", Length = "0x204")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001F5F")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D89")]
	private Length m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D8A")]
	private Length m_Y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D8B")]
	private float m_Z; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D8C")]
	private bool m_isNone; //Field offset: 0x14

	[Token(Token = "0x1700089B")]
	public Length x
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F53")]
		 get { } //Length: 4
		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F54")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700089C")]
	public Length y
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F55")]
		 get { } //Length: 5
		[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F56")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700089D")]
	public float z
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F57")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F58")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1B1D8A0", Offset = "0x1B1CAA0", Length = "0x11")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate), typeof(float)}, ReturnType = typeof(Translate))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001F4F")]
	public Translate(Length x, Length y, float z) { }

	[Address(RVA = "0x1B1D830", Offset = "0x1B1CA30", Length = "0x6F")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001F50")]
	internal Translate(Vector3 v) { }

	[Address(RVA = "0x1B1D580", Offset = "0x1B1C780", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001F5B")]
	public override bool Equals(Translate other) { }

	[Address(RVA = "0x1B1D5D0", Offset = "0x1B1C7D0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001F5C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F53")]
	public Length get_x() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F55")]
	public Length get_y() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F57")]
	public float get_z() { }

	[Address(RVA = "0x1B1C5E0", Offset = "0x1B1B7E0", Length = "0x71")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F5D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B1D690", Offset = "0x1B1C890", Length = "0x29")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001F52")]
	public static Translate None() { }

	[Address(RVA = "0x1B1D8C0", Offset = "0x1B1CAC0", Length = "0x104")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTranslate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate), typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTranslate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTranslate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Translate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Translate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Translate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F59")]
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	[Address(RVA = "0x1B1D9D0", Offset = "0x1B1CBD0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001F51")]
	public static Translate op_Implicit(Vector3 v) { }

	[Address(RVA = "0x1B1DAB0", Offset = "0x1B1CCB0", Length = "0x43")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001F5A")]
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F54")]
	public void set_x(Length value) { }

	[Address(RVA = "0x1508D40", Offset = "0x1507F40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F56")]
	public void set_y(Length value) { }

	[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F58")]
	public void set_z(float value) { }

	[Address(RVA = "0x1B1D6C0", Offset = "0x1B1C8C0", Length = "0x165")]
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
	[Token(Token = "0x6001F5E")]
	public virtual string ToString() { }

}

