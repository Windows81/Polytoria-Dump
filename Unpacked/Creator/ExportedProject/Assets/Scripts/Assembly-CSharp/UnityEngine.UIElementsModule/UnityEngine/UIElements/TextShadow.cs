namespace UnityEngine.UIElements;

[Token(Token = "0x2000492")]
public struct TextShadow : IEquatable<TextShadow>
{
	[Token(Token = "0x2000493")]
	public class PropertyBag : ContainerPropertyBag<TextShadow>
	{
		[Token(Token = "0x2000495")]
		private class BlurRadiusProperty : Property<TextShadow, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F92")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F93")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000950")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60022DF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700094F")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60022DE")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B3CD50", Offset = "0x1B3BF50", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60022E2")]
			public BlurRadiusProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60022DF")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60022DE")]
			public virtual string get_Name() { }

			[Address(RVA = "0x19F4E40", Offset = "0x19F4040", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60022E0")]
			public virtual float GetValue(ref TextShadow container) { }

			[Address(RVA = "0x19F4E50", Offset = "0x19F4050", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60022E1")]
			public virtual void SetValue(ref TextShadow container, float value) { }

		}

		[Token(Token = "0x2000496")]
		private class ColorProperty : Property<TextShadow, Color>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F94")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F95")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000952")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60022E4")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000951")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60022E3")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B3CDE0", Offset = "0x1B3BFE0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60022E7")]
			public ColorProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60022E4")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60022E3")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B3CDC0", Offset = "0x1B3BFC0", Length = "0xC")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60022E5")]
			public virtual Color GetValue(ref TextShadow container) { }

			[Address(RVA = "0x1B3CDD0", Offset = "0x1B3BFD0", Length = "0x9")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60022E6")]
			public virtual void SetValue(ref TextShadow container, Color value) { }

		}

		[Token(Token = "0x2000494")]
		private class OffsetProperty : Property<TextShadow, Vector2>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F90")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F91")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700094E")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60022DA")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700094D")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x60022D9")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B3DB60", Offset = "0x1B3CD60", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60022DD")]
			public OffsetProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60022DA")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60022D9")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B3DB40", Offset = "0x1B3CD40", Length = "0x12")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60022DB")]
			public virtual Vector2 GetValue(ref TextShadow container) { }

			[Address(RVA = "0x1B07720", Offset = "0x1B06920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60022DC")]
			public virtual void SetValue(ref TextShadow container, Vector2 value) { }

		}


		[Address(RVA = "0x1B3DEE0", Offset = "0x1B3D0E0", Length = "0x210")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60022D8")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F8D")]
	public Vector2 offset; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000F8E")]
	public float blurRadius; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000F8F")]
	public Color color; //Field offset: 0xC

	[Address(RVA = "0x1B42870", Offset = "0x1B41A70", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TextShadow), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60022D1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B42920", Offset = "0x1B41B20", Length = "0xBC")]
	[CalledBy(Type = typeof(TextShadow), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60022D2")]
	public override bool Equals(TextShadow other) { }

	[Address(RVA = "0x1B429E0", Offset = "0x1B41BE0", Length = "0xEF")]
	[CalledBy(Type = typeof(InheritedData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleTextShadow), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60022D3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B42AD0", Offset = "0x1B41CD0", Length = "0x13D")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow), typeof(float)}, ReturnType = typeof(TextShadow))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "UpdateValues", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60022D7")]
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }

	[Address(RVA = "0x1B42CE0", Offset = "0x1B41EE0", Length = "0x30")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InheritedData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData), typeof(InheritedData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow), typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTextShadow), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTextShadow), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextShadow), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60022D4")]
	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	[Address(RVA = "0x1B42D10", Offset = "0x1B41F10", Length = "0xB6")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60022D5")]
	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	[Address(RVA = "0x1B42C10", Offset = "0x1B41E10", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60022D6")]
	public virtual string ToString() { }

}

