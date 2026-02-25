namespace UnityEngine.Windows.Speech;

[Token(Token = "0x2000196")]
public abstract class PhraseRecognizer
{
	[Token(Token = "0x2000197")]
	internal sealed class PhraseRecognizedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x80C670", Offset = "0x80B870", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAB")]
		public PhraseRecognizedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x80C0F0", Offset = "0x80B2F0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAC")]
		public override void Invoke(PhraseRecognizedEventArgs args) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FC")]
	protected IntPtr m_Recognizer; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005FD")]
	private PhraseRecognizedDelegate OnPhraseRecognized; //Field offset: 0x18

	[Address(RVA = "0x1969A60", Offset = "0x1968C60", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BA9")]
	private void InvokePhraseRecognizedEvent(IntPtr rawText, int rawTextLength, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[Address(RVA = "0x1969BE0", Offset = "0x1968DE0", Length = "0x239")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BAA")]
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }

}

