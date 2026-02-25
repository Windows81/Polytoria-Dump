namespace UnityEngine.Android;

[NativeHeader("Modules/AndroidJNI/Public/AndroidInsets.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AndroidInsets", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000011")]
internal class AndroidInsets
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private IntPtr m_NativeHandle; //Field offset: 0x10

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000109")]
	private void SetNativeHandle(IntPtr ptr) { }

}

