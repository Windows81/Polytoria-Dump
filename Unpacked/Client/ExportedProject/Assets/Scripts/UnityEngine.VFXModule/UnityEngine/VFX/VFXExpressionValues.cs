namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000004")]
public class VFXExpressionValues
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	private VFXExpressionValues() { }

	[Address(RVA = "0x1D00230", Offset = "0x1CFF430", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600000E")]
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }

}

