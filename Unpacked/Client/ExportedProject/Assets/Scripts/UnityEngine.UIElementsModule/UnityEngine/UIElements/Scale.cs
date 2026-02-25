namespace UnityEngine.UIElements;

[Token(Token = "0x20003F0")]
public struct Scale : IEquatable<Scale>
{
	[Token(Token = "0x20003F1")]
	public class PropertyBag : ContainerPropertyBag<Scale>
	{
		[Token(Token = "0x20003F2")]
		private class ValueProperty : Property<Scale, Vector3>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D42")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D43")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000860")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DF0")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700085F")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DEF")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B1FEC0", Offset = "0x1B1F0C0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001DF3")]
			public ValueProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DF0")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DEF")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B1FD90", Offset = "0x1B1EF90", Length = "0x14")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001DF1")]
			public virtual Vector3 GetValue(ref Scale container) { }

			[Address(RVA = "0x19F5210", Offset = "0x19F4410", Length = "0x11")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DF2")]
			public virtual void SetValue(ref Scale container, Vector3 value) { }

		}


		[Address(RVA = "0x1B11BB0", Offset = "0x1B10DB0", Length = "0xF2")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001DEE")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D40")]
	private Vector3 m_Scale; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D41")]
	private bool m_IsNone; //Field offset: 0xC

	[Token(Token = "0x1700085E")]
	public Vector3 value
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DE6")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DE7")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x1B15440", Offset = "0x1B14640", Length = "0x13")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale), typeof(float)}, ReturnType = typeof(Scale))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "UpdateValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Scale))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6001DE3")]
	public Scale(Vector3 scale) { }

	[Address(RVA = "0x1B151C0", Offset = "0x1B143C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DEA")]
	public override bool Equals(Scale other) { }

	[Address(RVA = "0x1B15210", Offset = "0x1B14410", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DEB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE6")]
	public Vector3 get_value() { }

	[Address(RVA = "0x1B152E0", Offset = "0x1B144E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001DEC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B15340", Offset = "0x1B14540", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001DE4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Scale Initial() { }

	[Address(RVA = "0x1B153B0", Offset = "0x1B145B0", Length = "0x7C")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Scale))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001DE5")]
	public static Scale None() { }

	[Address(RVA = "0x1B15460", Offset = "0x1B14660", Length = "0x51")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DE8")]
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	[Address(RVA = "0x1B154C0", Offset = "0x1B146C0", Length = "0x4E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DE9")]
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE7")]
	public void set_value(Vector3 value) { }

	[Address(RVA = "0x1B15430", Offset = "0x1B14630", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D8580")]
	[Token(Token = "0x6001DED")]
	public virtual string ToString() { }

}

