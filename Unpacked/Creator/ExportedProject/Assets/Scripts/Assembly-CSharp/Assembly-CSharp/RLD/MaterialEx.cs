namespace RLD;

[Extension]
[Token(Token = "0x2000164")]
public static class MaterialEx
{

	[Address(RVA = "0x542D40", Offset = "0x541F40", Length = "0x60")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "DebugDraw", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTScene), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiSelectShape), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001001")]
	public static void SetColor(Material material, Color color) { }

	[Address(RVA = "0x542DB0", Offset = "0x541FB0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000FFE")]
	public static void SetCullModeBack(Material material) { }

	[Address(RVA = "0x542E00", Offset = "0x542000", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000FFF")]
	public static void SetCullModeFront(Material material) { }

	[Address(RVA = "0x542E50", Offset = "0x542050", Length = "0x49")]
	[CalledBy(Type = typeof(MultiSelectShape), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001000")]
	public static void SetCullModeOff(Material material) { }

	[Address(RVA = "0x542EA0", Offset = "0x5420A0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001002")]
	public static void SetStencilCmpAlways(Material material) { }

	[Address(RVA = "0x542EF0", Offset = "0x5420F0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001003")]
	public static void SetStencilCmpNotEqual(Material material) { }

	[Address(RVA = "0x542F40", Offset = "0x542140", Length = "0x4C")]
	[CalledBy(Type = typeof(RTScene), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000FFC")]
	public static void SetZTestAlways(Material material) { }

	[Address(RVA = "0x542F90", Offset = "0x542190", Length = "0x5D")]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000FFB")]
	public static void SetZTestEnabled(Material material, bool enabled) { }

	[Address(RVA = "0x542FF0", Offset = "0x5421F0", Length = "0x4C")]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000FFD")]
	public static void SetZTestLess(Material material) { }

	[Address(RVA = "0x543040", Offset = "0x542240", Length = "0x55")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000FFA")]
	public static void SetZWriteEnabled(Material material, bool enabled) { }

}

