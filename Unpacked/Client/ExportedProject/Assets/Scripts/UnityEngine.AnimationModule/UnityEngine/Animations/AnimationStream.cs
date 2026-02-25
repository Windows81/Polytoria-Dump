namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000028")]
public struct AnimationStream
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000065")]
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000066")]
	private IntPtr constant; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000067")]
	private IntPtr input; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000068")]
	private IntPtr output; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000069")]
	private IntPtr workspace; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006A")]
	private IntPtr inputStreamAccessor; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400006B")]
	private IntPtr animationHandleBinder; //Field offset: 0x30

}

