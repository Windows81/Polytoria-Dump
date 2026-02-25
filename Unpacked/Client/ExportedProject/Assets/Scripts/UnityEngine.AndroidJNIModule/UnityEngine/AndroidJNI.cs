namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000D")]
public static class AndroidJNI
{
	[Token(Token = "0x200000E")]
	private struct JStringBinding : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private IntPtr javaString; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400001F")]
		private IntPtr chars; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000020")]
		private int length; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000021")]
		private bool ownsRef; //Field offset: 0x14

		[Address(RVA = "0x190C780", Offset = "0x190B980", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000C9")]
		public override void Dispose() { }

		[Address(RVA = "0x190C7D0", Offset = "0x190B9D0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000C8")]
		public virtual string ToString() { }

	}


	[Address(RVA = "0x1906180", Offset = "0x1905380", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000078")]
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906120", Offset = "0x1905320", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000079")]
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906260", Offset = "0x1905460", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007E")]
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906200", Offset = "0x1905400", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600007F")]
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906340", Offset = "0x1905540", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000082")]
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x19062E0", Offset = "0x19054E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000083")]
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906420", Offset = "0x1905620", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000080")]
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x19063C0", Offset = "0x19055C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000081")]
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906500", Offset = "0x1905700", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x19064A0", Offset = "0x19056A0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000077")]
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x19065E0", Offset = "0x19057E0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906580", Offset = "0x1905780", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000085")]
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x19066C0", Offset = "0x19058C0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906660", Offset = "0x1905860", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000075")]
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x19067A0", Offset = "0x19059A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007C")]
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906740", Offset = "0x1905940", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600007D")]
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906880", Offset = "0x1905A80", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007A")]
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906820", Offset = "0x1905A20", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600007B")]
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906960", Offset = "0x1905B60", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008E")]
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906900", Offset = "0x1905B00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600008F")]
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906A40", Offset = "0x1905C40", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x19069E0", Offset = "0x1905BE0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000095")]
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906B20", Offset = "0x1905D20", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000098")]
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906AC0", Offset = "0x1905CC0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000099")]
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906C00", Offset = "0x1905E00", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906BA0", Offset = "0x1905DA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000097")]
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906CE0", Offset = "0x1905EE0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906C80", Offset = "0x1905E80", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600008D")]
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906DC0", Offset = "0x1905FC0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906D60", Offset = "0x1905F60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600009B")]
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906EA0", Offset = "0x19060A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906E40", Offset = "0x1906040", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600008B")]
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1906F80", Offset = "0x1906180", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000092")]
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1906F20", Offset = "0x1906120", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000093")]
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1907060", Offset = "0x1906260", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1907000", Offset = "0x1906200", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000091")]
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1907340", Offset = "0x1906540", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStaticStringMethodUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue*)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x19073B0", Offset = "0x19065B0", Length = "0xB0")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStaticStringMethodUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue*)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[Address(RVA = "0x19071D0", Offset = "0x19063D0", Length = "0x16C")]
	[CalledBy(Type = typeof(AndroidJNI), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AndroidJNI), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901F60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000088")]
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1907150", Offset = "0x1906350", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000089")]
	private static JStringBinding CallStaticStringMethodUnsafeInternal(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x19070E0", Offset = "0x19062E0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C3")]
	private static void CallStaticStringMethodUnsafeInternal_Injected(IntPtr clazz, IntPtr methodID, jvalue* args, out JStringBinding ret) { }

	[Address(RVA = "0x1907730", Offset = "0x1906930", Length = "0xB0")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStringMethodUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue*)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[Address(RVA = "0x19076C0", Offset = "0x19068C0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStringMethodUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue*)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1907550", Offset = "0x1906750", Length = "0x16C")]
	[CalledBy(Type = typeof(AndroidJNI), Member = "CallStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AndroidJNI), Member = "CallStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CallStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901F60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000072")]
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x19074D0", Offset = "0x19066D0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000073")]
	private static JStringBinding CallStringMethodUnsafeInternal(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x1907460", Offset = "0x1906660", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C2")]
	private static void CallStringMethodUnsafeInternal_Injected(IntPtr obj, IntPtr methodID, jvalue* args, out JStringBinding ret) { }

	[Address(RVA = "0x1907820", Offset = "0x1906A20", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600009C")]
	private static IntPtr ConvertToBooleanArray(Boolean[] array) { }

	[Address(RVA = "0x19077E0", Offset = "0x19069E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	private static IntPtr ConvertToBooleanArray_Injected(ref ManagedSpanWrapper array) { }

	[Address(RVA = "0x19078E0", Offset = "0x1906AE0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000065")]
	public static void DeleteLocalRef(IntPtr obj) { }

	[Address(RVA = "0x1907920", Offset = "0x1906B20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000063")]
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x1907960", Offset = "0x1906B60", Length = "0x2A")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600005D")]
	public static void ExceptionClear() { }

	[Address(RVA = "0x1907990", Offset = "0x1906B90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600005C")]
	public static IntPtr ExceptionOccurred() { }

	[Address(RVA = "0x1907A00", Offset = "0x1906C00", Length = "0x180")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600005A")]
	public static IntPtr FindClass(string name) { }

	[Address(RVA = "0x19079C0", Offset = "0x1906BC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BD")]
	private static IntPtr FindClass_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x1907BE0", Offset = "0x1906DE0", Length = "0xBC")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "FromBooleanArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Boolean[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181902230")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000AF")]
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	[Address(RVA = "0x1907B90", Offset = "0x1906D90", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C6")]
	private static void FromBooleanArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x1907CF0", Offset = "0x1906EF0", Length = "0xBC")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "FromByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901FB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	[Token(Token = "0x60000B0")]
	public static Byte[] FromByteArray(IntPtr array) { }

	[Address(RVA = "0x1907CA0", Offset = "0x1906EA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C7")]
	private static void FromByteArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x1907DB0", Offset = "0x1906FB0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B2")]
	public static Char[] FromCharArray(IntPtr array) { }

	[Address(RVA = "0x1907DF0", Offset = "0x1906FF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B7")]
	public static Double[] FromDoubleArray(IntPtr array) { }

	[Address(RVA = "0x1907E30", Offset = "0x1907030", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B6")]
	public static Single[] FromFloatArray(IntPtr array) { }

	[Address(RVA = "0x1907E70", Offset = "0x1907070", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B4")]
	public static Int32[] FromIntArray(IntPtr array) { }

	[Address(RVA = "0x1907EB0", Offset = "0x19070B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B5")]
	public static Int64[] FromLongArray(IntPtr array) { }

	[Address(RVA = "0x1907EF0", Offset = "0x19070F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600005B")]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[Address(RVA = "0x1907F30", Offset = "0x1907130", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B1")]
	public static SByte[] FromSByteArray(IntPtr array) { }

	[Address(RVA = "0x1907F70", Offset = "0x1907170", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B3")]
	public static Int16[] FromShortArray(IntPtr array) { }

	[Address(RVA = "0x1907FB0", Offset = "0x19071B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B8")]
	public static int GetArrayLength(IntPtr array) { }

	[Address(RVA = "0x1908050", Offset = "0x1907250", Length = "0x28C")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006A")]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[Address(RVA = "0x1907FF0", Offset = "0x19071F0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BE")]
	private static IntPtr GetMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	[Address(RVA = "0x19082E0", Offset = "0x19074E0", Length = "0x40")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000BA")]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[Address(RVA = "0x1908320", Offset = "0x1907520", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000069")]
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[Address(RVA = "0x19083C0", Offset = "0x19075C0", Length = "0x28C")]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006B")]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[Address(RVA = "0x1908360", Offset = "0x1907560", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BF")]
	private static IntPtr GetStaticMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	[Address(RVA = "0x1908700", Offset = "0x1907900", Length = "0x14C")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "InvokeJavaProxyMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaProxy), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "GetStringChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901F60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600006E")]
	public static string GetStringChars(IntPtr str) { }

	[Address(RVA = "0x19086A0", Offset = "0x19078A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006F")]
	private static JStringBinding GetStringCharsInternal(IntPtr str) { }

	[Address(RVA = "0x1908650", Offset = "0x1907850", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C1")]
	private static void GetStringCharsInternal_Injected(IntPtr str, out JStringBinding ret) { }

	[Address(RVA = "0x1908850", Offset = "0x1907A50", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000059")]
	private static void InvokeAction(Action action) { }

	[Address(RVA = "0x1908880", Offset = "0x1907A80", Length = "0x42")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000066")]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[Address(RVA = "0x19088D0", Offset = "0x1907AD0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000060")]
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x1908910", Offset = "0x1907B10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000064")]
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[Address(RVA = "0x1908A00", Offset = "0x1907C00", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x1908950", Offset = "0x1907B50", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000068")]
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x19089B0", Offset = "0x1907BB0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000B9")]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[Address(RVA = "0x1908C50", Offset = "0x1907E50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNI), Member = "NewStringFromStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600006C")]
	public static IntPtr NewString(string chars) { }

	[Address(RVA = "0x1908AC0", Offset = "0x1907CC0", Length = "0x180")]
	[CalledBy(Type = typeof(AndroidJNI), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006D")]
	private static IntPtr NewStringFromStr(string chars) { }

	[Address(RVA = "0x1908A80", Offset = "0x1907C80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	private static IntPtr NewStringFromStr_Injected(ref ManagedSpanWrapper chars) { }

	[Address(RVA = "0x1908C60", Offset = "0x1907E60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000062")]
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x1908CA0", Offset = "0x1907EA0", Length = "0x33")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600005F")]
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[Address(RVA = "0x1908CE0", Offset = "0x1907EE0", Length = "0x31")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600005E")]
	public static int PushLocalFrame(int capacity) { }

	[Address(RVA = "0x1908D20", Offset = "0x1907F20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000061")]
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x1908DA0", Offset = "0x1907FA0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000058")]
	private static void ReleaseStringChars(JStringBinding str) { }

	[Address(RVA = "0x1908D60", Offset = "0x1907F60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	private static void ReleaseStringChars_Injected(in JStringBinding str) { }

	[Address(RVA = "0x1908DE0", Offset = "0x1907FE0", Length = "0x50")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000BB")]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[Address(RVA = "0x1908E30", Offset = "0x1908030", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009D")]
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	[Address(RVA = "0x1908F30", Offset = "0x1908130", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	[Token(Token = "0x600009E")]
	public static IntPtr ToByteArray(Byte[] array) { }

	[Address(RVA = "0x1908EF0", Offset = "0x19080F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C5")]
	private static IntPtr ToByteArray_Injected(ref ManagedSpanWrapper array) { }

	[Address(RVA = "0x1908FF0", Offset = "0x19081F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000A2")]
	public static IntPtr ToCharArray(Char* array, int length) { }

	[Address(RVA = "0x1909030", Offset = "0x1908230", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	public static IntPtr ToCharArray(Char[] array) { }

	[Address(RVA = "0x1909110", Offset = "0x1908310", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000AC")]
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	[Address(RVA = "0x19090A0", Offset = "0x19082A0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AB")]
	public static IntPtr ToDoubleArray(Double[] array) { }

	[Address(RVA = "0x19091C0", Offset = "0x19083C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000AA")]
	public static IntPtr ToFloatArray(Single* array, int length) { }

	[Address(RVA = "0x1909150", Offset = "0x1908350", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A9")]
	public static IntPtr ToFloatArray(Single[] array) { }

	[Address(RVA = "0x1909200", Offset = "0x1908400", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000A6")]
	public static IntPtr ToIntArray(Int32* array, int length) { }

	[Address(RVA = "0x1909240", Offset = "0x1908440", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A5")]
	public static IntPtr ToIntArray(Int32[] array) { }

	[Address(RVA = "0x1909320", Offset = "0x1908520", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000A8")]
	public static IntPtr ToLongArray(Int64* array, int length) { }

	[Address(RVA = "0x19092B0", Offset = "0x19084B0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A7")]
	public static IntPtr ToLongArray(Int64[] array) { }

	[Address(RVA = "0x19093E0", Offset = "0x19085E0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000AD")]
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	[Address(RVA = "0x1909360", Offset = "0x1908560", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AE")]
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[Address(RVA = "0x19094A0", Offset = "0x19086A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000A0")]
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	[Address(RVA = "0x1909430", Offset = "0x1908630", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009F")]
	public static IntPtr ToSByteArray(SByte[] array) { }

	[Address(RVA = "0x1909520", Offset = "0x1908720", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A3")]
	public static IntPtr ToShortArray(Int16[] array) { }

	[Address(RVA = "0x19094E0", Offset = "0x19086E0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60000A4")]
	public static IntPtr ToShortArray(Int16* array, int length) { }

}

