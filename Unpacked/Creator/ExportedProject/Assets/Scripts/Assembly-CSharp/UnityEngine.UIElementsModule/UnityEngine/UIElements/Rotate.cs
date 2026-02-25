namespace UnityEngine.UIElements;

[Token(Token = "0x20003EC")]
public struct Rotate : IEquatable<Rotate>
{
	[Token(Token = "0x20003ED")]
	public class PropertyBag : ContainerPropertyBag<Rotate>
	{
		[Token(Token = "0x20003EE")]
		private class AngleProperty : Property<Rotate, Angle>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D3C")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D3D")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700085B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DDA")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700085A")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DD9")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B07730", Offset = "0x1B06930", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001DDD")]
			public AngleProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DDA")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DD9")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1A16EE0", Offset = "0x1A160E0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DDB")]
			public virtual Angle GetValue(ref Rotate container) { }

			[Address(RVA = "0x1B07720", Offset = "0x1B06920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DDC")]
			public virtual void SetValue(ref Rotate container, Angle value) { }

		}

		[Token(Token = "0x20003EF")]
		private class AxisProperty : Property<Rotate, Vector3>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D3E")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D3F")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700085D")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DDF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700085C")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001DDE")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B077E0", Offset = "0x1B069E0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001DE2")]
			public AxisProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DDF")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DDE")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B077A0", Offset = "0x1B069A0", Length = "0x15")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001DE0")]
			public virtual Vector3 GetValue(ref Rotate container) { }

			[Address(RVA = "0x1B077C0", Offset = "0x1B069C0", Length = "0x12")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001DE1")]
			public virtual void SetValue(ref Rotate container, Vector3 value) { }

		}


		[Address(RVA = "0x1B11A20", Offset = "0x1B10C20", Length = "0x181")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001DD8")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D39")]
	private Angle m_Angle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D3A")]
	private Vector3 m_Axis; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D3B")]
	private bool m_IsNone; //Field offset: 0x14

	[Token(Token = "0x17000858")]
	public Angle angle
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DCD")]
		 get { } //Length: 4
		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DCE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000859")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Vector3 axis
	{
		[Address(RVA = "0x3B8780", Offset = "0x3B7980", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DCF")]
		internal get { } //Length: 19
		[Address(RVA = "0x3B8820", Offset = "0x3B7A20", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DD0")]
		internal set { } //Length: 16
	}

	[Address(RVA = "0x1B14E00", Offset = "0x1B14000", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate), typeof(float)}, ReturnType = typeof(Rotate))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "UpdateValues", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001DC8")]
	public Rotate(Angle angle, Vector3 axis) { }

	[Address(RVA = "0x1B14E20", Offset = "0x1B14020", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001DC9")]
	public Rotate(Angle angle) { }

	[Address(RVA = "0x1B14D80", Offset = "0x1B13F80", Length = "0x75")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToAxisAngleRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DCA")]
	public Rotate(Quaternion quaternion) { }

	[Address(RVA = "0x1B14A00", Offset = "0x1B13C00", Length = "0xDF")]
	[CalledBy(Type = typeof(Rotate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DD3")]
	public override bool Equals(Rotate other) { }

	[Address(RVA = "0x1B14960", Offset = "0x1B13B60", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Rotate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001DD4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCD")]
	public Angle get_angle() { }

	[Address(RVA = "0x3B8780", Offset = "0x3B7980", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCF")]
	internal Vector3 get_axis() { }

	[Address(RVA = "0x1B14AE0", Offset = "0x1B13CE0", Length = "0xAE")]
	[CalledBy(Type = typeof(TransformData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleRotate), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DD5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B14B90", Offset = "0x1B13D90", Length = "0x86")]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveRotation", ReturnType = typeof(Quaternion))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Rotate))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DCB")]
	internal static Rotate Initial() { }

	[Address(RVA = "0x1B14C20", Offset = "0x1B13E20", Length = "0x97")]
	[CalledBy(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Rotate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DCC")]
	public static Rotate None() { }

	[Address(RVA = "0x1B14E70", Offset = "0x1B14070", Length = "0xEB")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleRotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate), typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleRotate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleRotate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DD1")]
	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	[Address(RVA = "0x1B14F60", Offset = "0x1B14160", Length = "0xEB")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DD2")]
	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCE")]
	public void set_angle(Angle value) { }

	[Address(RVA = "0x3B8820", Offset = "0x3B7A20", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD0")]
	internal void set_axis(Vector3 value) { }

	[Address(RVA = "0x1B14CC0", Offset = "0x1B13EC0", Length = "0x5B")]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveRotation", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Angle), Member = "ToDegrees", ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001DD7")]
	internal Quaternion ToQuaternion() { }

	[Address(RVA = "0x1B14D20", Offset = "0x1B13F20", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Angle), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D8580")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001DD6")]
	public virtual string ToString() { }

}

