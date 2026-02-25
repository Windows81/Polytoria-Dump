namespace UnityEngine.UIElements;

[Token(Token = "0x20002E4")]
public struct Background : IEquatable<Background>
{
	[Token(Token = "0x20002E5")]
	public class PropertyBag : ContainerPropertyBag<Background>
	{
		[Token(Token = "0x20002E8")]
		private class RenderTextureProperty : Property<Background, RenderTexture>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BB3")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BB4")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003E9")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001440")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003E8")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600143F")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AE9490", Offset = "0x1AE8690", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001443")]
			public RenderTextureProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001440")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600143F")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AE9460", Offset = "0x1AE8660", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001441")]
			public virtual RenderTexture GetValue(ref Background container) { }

			[Address(RVA = "0x1AE9470", Offset = "0x1AE8670", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Background), Member = "set_renderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001442")]
			public virtual void SetValue(ref Background container, RenderTexture value) { }

		}

		[Token(Token = "0x20002E7")]
		private class SpriteProperty : Property<Background, Sprite>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BB1")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BB2")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003E7")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600143B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003E6")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600143A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AE9E40", Offset = "0x1AE9040", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600143E")]
			public SpriteProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600143B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600143A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1ADA390", Offset = "0x1AD9590", Length = "0x7")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600143C")]
			public virtual Sprite GetValue(ref Background container) { }

			[Address(RVA = "0x1AE9E20", Offset = "0x1AE9020", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Background), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
			[Token(Token = "0x600143D")]
			public virtual void SetValue(ref Background container, Sprite value) { }

		}

		[Token(Token = "0x20002E6")]
		private class TextureProperty : Property<Background, Texture2D>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BAF")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BB0")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003E5")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001436")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003E4")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001435")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AEA320", Offset = "0x1AE9520", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001439")]
			public TextureProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001436")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001435")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1ADAB40", Offset = "0x1AD9D40", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001437")]
			public virtual Texture2D GetValue(ref Background container) { }

			[Address(RVA = "0x1AEA300", Offset = "0x1AE9500", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Background), Member = "set_texture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001438")]
			public virtual void SetValue(ref Background container, Texture2D value) { }

		}

		[Token(Token = "0x20002E9")]
		private class VectorImageProperty : Property<Background, VectorImage>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BB5")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BB6")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003EB")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001445")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003EA")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001444")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AEE620", Offset = "0x1AED820", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001448")]
			public VectorImageProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001445")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001444")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AEE5F0", Offset = "0x1AED7F0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001446")]
			public virtual VectorImage GetValue(ref Background container) { }

			[Address(RVA = "0x1AEE600", Offset = "0x1AED800", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Background), Member = "set_vectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001447")]
			public virtual void SetValue(ref Background container, VectorImage value) { }

		}


		[Address(RVA = "0x1AE8DA0", Offset = "0x1AE7FA0", Length = "0x29F")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6001434")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BAB")]
	private Texture2D m_Texture; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BAC")]
	private Sprite m_Sprite; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BAD")]
	private RenderTexture m_RenderTexture; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BAE")]
	private VectorImage m_VectorImage; //Field offset: 0x18

	[Token(Token = "0x170003E2")]
	public RenderTexture renderTexture
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001423")]
		 get { } //Length: 7
		[Address(RVA = "0x1AD4900", Offset = "0x1AD3B00", Length = "0xA9")]
		[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+RenderTextureProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001424")]
		 set { } //Length: 169
	}

	[Token(Token = "0x170003E1")]
	public Sprite sprite
	{
		[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001421")]
		 get { } //Length: 7
		[Address(RVA = "0x1AD49B0", Offset = "0x1AD3BB0", Length = "0xA9")]
		[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+SpriteProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001422")]
		 set { } //Length: 169
	}

	[Token(Token = "0x170003E0")]
	public Texture2D texture
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x600141F")]
		 get { } //Length: 6
		[Address(RVA = "0x1AD4A60", Offset = "0x1AD3C60", Length = "0xA8")]
		[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+TextureProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001420")]
		 set { } //Length: 168
	}

	[Token(Token = "0x170003E3")]
	public VectorImage vectorImage
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001425")]
		 get { } //Length: 7
		[Address(RVA = "0x1AD4B10", Offset = "0x1AD3D10", Length = "0xA9")]
		[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+VectorImageProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(VectorImage)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001426")]
		 set { } //Length: 169
	}

	[Address(RVA = "0x1AD3A40", Offset = "0x1AD2C40", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001431")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1AD3BE0", Offset = "0x1AD2DE0", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001430")]
	public override bool Equals(Background other) { }

	[Address(RVA = "0x1AD3CE0", Offset = "0x1AD2EE0", Length = "0x386")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlImageAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[Token(Token = "0x600142B")]
	internal static Background FromObject(object obj) { }

	[Address(RVA = "0x1AD4070", Offset = "0x1AD3270", Length = "0xD7")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001428")]
	public static Background FromRenderTexture(RenderTexture rt) { }

	[Address(RVA = "0x1AD4150", Offset = "0x1AD3350", Length = "0xD7")]
	[CalledBy(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
	[CalledBy(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001429")]
	public static Background FromSprite(Sprite s) { }

	[Address(RVA = "0x1AD4230", Offset = "0x1AD3430", Length = "0xDC")]
	[CalledBy(Type = typeof(Background), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Background))]
	[CalledBy(Type = typeof(Background), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[CalledBy(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
	[CalledBy(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001427")]
	public static Background FromTexture2D(Texture2D t) { }

	[Address(RVA = "0x1AD4310", Offset = "0x1AD3510", Length = "0xD7")]
	[CalledBy(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
	[CalledBy(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600142A")]
	public static Background FromVectorImage(VectorImage vi) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001423")]
	public RenderTexture get_renderTexture() { }

	[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001421")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x600141F")]
	public Texture2D get_texture() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001425")]
	public VectorImage get_vectorImage() { }

	[Address(RVA = "0x1AD43F0", Offset = "0x1AD35F0", Length = "0xCA")]
	[CalledBy(Type = typeof(VisualData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleBackground), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001432")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1AD44C0", Offset = "0x1AD36C0", Length = "0xE8")]
	[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600142C")]
	public bool IsEmpty() { }

	[Address(RVA = "0x1AD46E0", Offset = "0x1AD38E0", Length = "0xE6")]
	[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_icon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData), typeof(VisualData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackground), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackground), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackground), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600142D")]
	public static bool op_Equality(Background lhs, Background rhs) { }

	[Address(RVA = "0x1AD47D0", Offset = "0x1AD39D0", Length = "0x37")]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[Token(Token = "0x600142F")]
	public static Background op_Implicit(Texture2D v) { }

	[Address(RVA = "0x1AD4810", Offset = "0x1AD3A10", Length = "0xEA")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600142E")]
	public static bool op_Inequality(Background lhs, Background rhs) { }

	[Address(RVA = "0x1AD4900", Offset = "0x1AD3B00", Length = "0xA9")]
	[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+RenderTextureProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001424")]
	public void set_renderTexture(RenderTexture value) { }

	[Address(RVA = "0x1AD49B0", Offset = "0x1AD3BB0", Length = "0xA9")]
	[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+SpriteProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001422")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x1AD4A60", Offset = "0x1AD3C60", Length = "0xA8")]
	[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+TextureProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001420")]
	public void set_texture(Texture2D value) { }

	[Address(RVA = "0x1AD4B10", Offset = "0x1AD3D10", Length = "0xA9")]
	[CalledBy(Type = "UnityEngine.UIElements.Background+PropertyBag+VectorImageProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background&), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001426")]
	public void set_vectorImage(VectorImage value) { }

	[Address(RVA = "0x1AD45B0", Offset = "0x1AD37B0", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001433")]
	public virtual string ToString() { }

}

