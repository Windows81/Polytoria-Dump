namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000065")]
public sealed class SpriteRenderer : Renderer
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C3")]
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; //Field offset: 0x18

	[Token(Token = "0x1700001F")]
	public Color color
	{
		[Address(RVA = "0x193F520", Offset = "0x193E720", Length = "0x8E")]
		[CalledBy(Type = "LTDescr", Member = "alphaRecursiveSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_0", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_2", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_1", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setColor>b__96_0", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000100")]
		 get { } //Length: 142
		[Address(RVA = "0x193F6E0", Offset = "0x193E8E0", Length = "0x85")]
		[CalledBy(Type = "LTDescr", Member = "alphaRecursiveSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "colorRecursiveSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_2", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_1", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setColor>b__96_1", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setCallbackColor>b__97_1", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000101")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700001E")]
	public Sprite sprite
	{
		[Address(RVA = "0x193F5F0", Offset = "0x193E7F0", Length = "0x90")]
		[CalledBy(Type = "RLD.GameObjectEx", Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "RLD.GameObjectType")]
		[CalledBy(Type = "RLD.GameObjectEx", Member = "HierarchyHasSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.GameObjectEx", Member = "GetSpriteObjectsInHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "System.Collections.Generic.List`1<GameObject>")]
		[CalledBy(Type = "RLD.GameObjectEx", Member = "GetSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Sprite))]
		[CalledBy(Type = "RLD.SpriteRendererEx", Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.SpriteRendererEx", Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000102")]
	public SpriteRenderer() { }

	[Address(RVA = "0x193F520", Offset = "0x193E720", Length = "0x8E")]
	[CalledBy(Type = "LTDescr", Member = "alphaRecursiveSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_0", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_2", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_1", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setColor>b__96_0", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000100")]
	public Color get_color() { }

	[Address(RVA = "0x193F4D0", Offset = "0x193E6D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000104")]
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x193F5F0", Offset = "0x193E7F0", Length = "0x90")]
	[CalledBy(Type = "RLD.GameObjectEx", Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "RLD.GameObjectType")]
	[CalledBy(Type = "RLD.GameObjectEx", Member = "HierarchyHasSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.GameObjectEx", Member = "GetSpriteObjectsInHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "System.Collections.Generic.List`1<GameObject>")]
	[CalledBy(Type = "RLD.GameObjectEx", Member = "GetSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "RLD.SpriteRendererEx", Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.SpriteRendererEx", Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FF")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x193F5B0", Offset = "0x193E7B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000103")]
	private static IntPtr get_sprite_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193F450", Offset = "0x193E650", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x60000FE")]
	private void InvokeSpriteChanged() { }

	[Address(RVA = "0x193F6E0", Offset = "0x193E8E0", Length = "0x85")]
	[CalledBy(Type = "LTDescr", Member = "alphaRecursiveSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "colorRecursiveSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_2", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setAlpha>b__93_1", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setColor>b__96_1", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setCallbackColor>b__97_1", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000101")]
	public void set_color(Color value) { }

	[Address(RVA = "0x193F690", Offset = "0x193E890", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000105")]
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

}

