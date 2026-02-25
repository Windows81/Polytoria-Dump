namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[Token(Token = "0x2000327")]
public class SpriteAtlas : object
{

	[Address(RVA = "0x198F730", Offset = "0x198E930", Length = "0xD1")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "RebuildImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0E")]
	public bool CanBindTo(Sprite sprite) { }

	[Address(RVA = "0x198F6E0", Offset = "0x198E8E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0F")]
	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

}

