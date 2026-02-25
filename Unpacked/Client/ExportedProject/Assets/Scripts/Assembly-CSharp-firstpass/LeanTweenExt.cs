//Type is in global namespace

[Extension]
[Token(Token = "0x200001C")]
public static class LeanTweenExt
{

	[Address(RVA = "0x2F2640", Offset = "0x2F1840", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600017D")]
	public static LTDescr LeanAlpha(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F25D0", Offset = "0x2F17D0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600017F")]
	public static LTDescr LeanAlpha(RectTransform rectTransform, float to, float time) { }

	[Address(RVA = "0x2F26B0", Offset = "0x2F18B0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "alphaCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasGroup), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000180")]
	public static LTDescr LeanAlpha(CanvasGroup canvas, float to, float time) { }

	[Address(RVA = "0x2F24F0", Offset = "0x2F16F0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "alphaText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000181")]
	public static LTDescr LeanAlphaText(RectTransform rectTransform, float to, float time) { }

	[Address(RVA = "0x2F2560", Offset = "0x2F1760", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "alphaVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600017E")]
	public static LTDescr LeanAlphaVertex(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F27F0", Offset = "0x2F19F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000182")]
	public static void LeanCancel(GameObject gameObject) { }

	[Address(RVA = "0x2F2720", Offset = "0x2F1920", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000183")]
	public static void LeanCancel(GameObject gameObject, bool callOnComplete) { }

	[Address(RVA = "0x2F2780", Offset = "0x2F1980", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000184")]
	public static void LeanCancel(GameObject gameObject, int uniqueId, bool callOnComplete = false) { }

	[Address(RVA = "0x2F2840", Offset = "0x2F1A40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000185")]
	public static void LeanCancel(RectTransform rectTransform) { }

	[Address(RVA = "0x2F2910", Offset = "0x2F1B10", Length = "0x7D")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__9", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__9", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__9", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__9", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Material), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60001DF")]
	public static Color LeanColor(Transform transform) { }

	[Address(RVA = "0x2F2990", Offset = "0x2F1B90", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Color), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000186")]
	public static LTDescr LeanColor(GameObject gameObject, Color to, float time) { }

	[Address(RVA = "0x2F2890", Offset = "0x2F1A90", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "colorText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Color), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000187")]
	public static LTDescr LeanColorText(RectTransform rectTransform, Color to, float time) { }

	[Address(RVA = "0x2F2A10", Offset = "0x2F1C10", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "delayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000189")]
	public static LTDescr LeanDelayedCall(GameObject gameObject, float delayTime, Action<Object> callback) { }

	[Address(RVA = "0x2F2A80", Offset = "0x2F1C80", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "delayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(Action)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000188")]
	public static LTDescr LeanDelayedCall(GameObject gameObject, float delayTime, Action callback) { }

	[Address(RVA = "0x2F2AF0", Offset = "0x2F1CF0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "isPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x600018A")]
	public static bool LeanIsPaused(GameObject gameObject) { }

	[Address(RVA = "0x2F2B40", Offset = "0x2F1D40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "isPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x600018B")]
	public static bool LeanIsPaused(RectTransform rectTransform) { }

	[Address(RVA = "0x2F2B90", Offset = "0x2F1D90", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "isTweening", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x600018C")]
	public static bool LeanIsTweening(GameObject gameObject) { }

	[Address(RVA = "0x2F3BE0", Offset = "0x2F2DE0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTSpline), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000197")]
	public static LTDescr LeanMove(Transform transform, LTSpline to, float time) { }

	[Address(RVA = "0x2F3950", Offset = "0x2F2B50", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTBezierPath), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000196")]
	public static LTDescr LeanMove(Transform transform, LTBezierPath to, float time) { }

	[Address(RVA = "0x2F3DF0", Offset = "0x2F2FF0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000195")]
	public static LTDescr LeanMove(Transform transform, Vector3[] to, float time) { }

	[Address(RVA = "0x2F3AF0", Offset = "0x2F2CF0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTSpline), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000194")]
	public static LTDescr LeanMove(GameObject gameObject, LTSpline to, float time) { }

	[Address(RVA = "0x2F3CF0", Offset = "0x2F2EF0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTBezierPath), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000193")]
	public static LTDescr LeanMove(GameObject gameObject, LTBezierPath to, float time) { }

	[Address(RVA = "0x2F3D60", Offset = "0x2F2F60", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000191")]
	public static LTDescr LeanMove(Transform transform, Vector2 to, float time) { }

	[Address(RVA = "0x2F3C70", Offset = "0x2F2E70", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600018F")]
	public static LTDescr LeanMove(RectTransform rectTransform, Vector3 to, float time) { }

	[Address(RVA = "0x2F3A50", Offset = "0x2F2C50", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600018E")]
	public static LTDescr LeanMove(Transform transform, Vector3 to, float time) { }

	[Address(RVA = "0x2F3B60", Offset = "0x2F2D60", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600018D")]
	public static LTDescr LeanMove(GameObject gameObject, Vector3 to, float time) { }

	[Address(RVA = "0x2F3E80", Offset = "0x2F3080", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000192")]
	public static LTDescr LeanMove(GameObject gameObject, Vector3[] to, float time) { }

	[Address(RVA = "0x2F39E0", Offset = "0x2F2BE0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000190")]
	public static LTDescr LeanMove(GameObject gameObject, Vector2 to, float time) { }

	[Address(RVA = "0x2F2FF0", Offset = "0x2F21F0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTBezierPath), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600019C")]
	public static LTDescr LeanMoveLocal(Transform transform, LTBezierPath to, float time) { }

	[Address(RVA = "0x2F2EE0", Offset = "0x2F20E0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTSpline), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600019D")]
	public static LTDescr LeanMoveLocal(Transform transform, LTSpline to, float time) { }

	[Address(RVA = "0x2F3080", Offset = "0x2F2280", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTSpline), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600019A")]
	public static LTDescr LeanMoveLocal(GameObject gameObject, LTSpline to, float time) { }

	[Address(RVA = "0x2F3190", Offset = "0x2F2390", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTBezierPath), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000199")]
	public static LTDescr LeanMoveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	[Address(RVA = "0x2F2F70", Offset = "0x2F2170", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x6000198")]
	public static LTDescr LeanMoveLocal(GameObject gameObject, Vector3 to, float time) { }

	[Address(RVA = "0x2F30F0", Offset = "0x2F22F0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600019B")]
	public static LTDescr LeanMoveLocal(Transform transform, Vector3 to, float time) { }

	[Address(RVA = "0x2F2C70", Offset = "0x2F1E70", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocalX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600019E")]
	public static LTDescr LeanMoveLocalX(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F2BE0", Offset = "0x2F1DE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocalX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A1")]
	public static LTDescr LeanMoveLocalX(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F2CE0", Offset = "0x2F1EE0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocalY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x600019F")]
	public static LTDescr LeanMoveLocalY(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F2D50", Offset = "0x2F1F50", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocalY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A2")]
	public static LTDescr LeanMoveLocalY(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F2E70", Offset = "0x2F2070", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocalZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001A0")]
	public static LTDescr LeanMoveLocalZ(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F2DE0", Offset = "0x2F1FE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveLocalZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A3")]
	public static LTDescr LeanMoveLocalZ(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F3370", Offset = "0x2F2570", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveSpline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTSpline), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A7")]
	public static LTDescr LeanMoveSpline(Transform transform, LTSpline to, float time) { }

	[Address(RVA = "0x2F3490", Offset = "0x2F2690", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveSpline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LTSpline), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001A5")]
	public static LTDescr LeanMoveSpline(GameObject gameObject, LTSpline to, float time) { }

	[Address(RVA = "0x2F3300", Offset = "0x2F2500", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveSpline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001A4")]
	public static LTDescr LeanMoveSpline(GameObject gameObject, Vector3[] to, float time) { }

	[Address(RVA = "0x2F3400", Offset = "0x2F2600", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveSpline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A6")]
	public static LTDescr LeanMoveSpline(Transform transform, Vector3[] to, float time) { }

	[Address(RVA = "0x2F3200", Offset = "0x2F2400", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveSplineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001A8")]
	public static LTDescr LeanMoveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	[Address(RVA = "0x2F3270", Offset = "0x2F2470", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveSplineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001A9")]
	public static LTDescr LeanMoveSplineLocal(Transform transform, Vector3[] to, float time) { }

	[Address(RVA = "0x2F3600", Offset = "0x2F2800", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001AA")]
	public static LTDescr LeanMoveX(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F3570", Offset = "0x2F2770", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001AB")]
	public static LTDescr LeanMoveX(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F3500", Offset = "0x2F2700", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001AC")]
	public static LTDescr LeanMoveX(RectTransform rectTransform, float to, float time) { }

	[Address(RVA = "0x2F3670", Offset = "0x2F2870", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001AF")]
	public static LTDescr LeanMoveY(RectTransform rectTransform, float to, float time) { }

	[Address(RVA = "0x2F36E0", Offset = "0x2F28E0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001AE")]
	public static LTDescr LeanMoveY(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F3770", Offset = "0x2F2970", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001AD")]
	public static LTDescr LeanMoveY(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F37E0", Offset = "0x2F29E0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001B0")]
	public static LTDescr LeanMoveZ(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F3850", Offset = "0x2F2A50", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001B1")]
	public static LTDescr LeanMoveZ(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F38E0", Offset = "0x2F2AE0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "moveZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001B2")]
	public static LTDescr LeanMoveZ(RectTransform rectTransform, float to, float time) { }

	[Address(RVA = "0x2F3EF0", Offset = "0x2F30F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "pause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x60001B3")]
	public static void LeanPause(GameObject gameObject) { }

	[Address(RVA = "0x2F3F40", Offset = "0x2F3140", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Sprite[])}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001B4")]
	public static LTDescr LeanPlay(RectTransform rectTransform, Sprite[] sprites) { }

	[Address(RVA = "0x2F3FA0", Offset = "0x2F31A0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x60001B5")]
	public static void LeanResume(GameObject gameObject) { }

	[Address(RVA = "0x2F4750", Offset = "0x2F3950", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001B7")]
	public static LTDescr LeanRotate(Transform transform, Vector3 to, float time) { }

	[Address(RVA = "0x2F46D0", Offset = "0x2F38D0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001B8")]
	public static LTDescr LeanRotate(RectTransform rectTransform, Vector3 to, float time) { }

	[Address(RVA = "0x2F47F0", Offset = "0x2F39F0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001B6")]
	public static LTDescr LeanRotate(GameObject gameObject, Vector3 to, float time) { }

	[Address(RVA = "0x2F4330", Offset = "0x2F3530", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001B9")]
	public static LTDescr LeanRotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	[Address(RVA = "0x2F4280", Offset = "0x2F3480", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001BA")]
	public static LTDescr LeanRotateAround(Transform transform, Vector3 axis, float add, float time) { }

	[Address(RVA = "0x2F41E0", Offset = "0x2F33E0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001BB")]
	public static LTDescr LeanRotateAround(RectTransform rectTransform, Vector3 axis, float add, float time) { }

	[Address(RVA = "0x2F40A0", Offset = "0x2F32A0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateAroundLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001BC")]
	public static LTDescr LeanRotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	[Address(RVA = "0x2F4140", Offset = "0x2F3340", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateAroundLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001BE")]
	public static LTDescr LeanRotateAroundLocal(RectTransform rectTransform, Vector3 axis, float add, float time) { }

	[Address(RVA = "0x2F3FF0", Offset = "0x2F31F0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateAroundLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001BD")]
	public static LTDescr LeanRotateAroundLocal(Transform transform, Vector3 axis, float add, float time) { }

	[Address(RVA = "0x2F4460", Offset = "0x2F3660", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001BF")]
	public static LTDescr LeanRotateX(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F43D0", Offset = "0x2F35D0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001C0")]
	public static LTDescr LeanRotateX(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F44D0", Offset = "0x2F36D0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001C1")]
	public static LTDescr LeanRotateY(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F4540", Offset = "0x2F3740", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001C2")]
	public static LTDescr LeanRotateY(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F45D0", Offset = "0x2F37D0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001C4")]
	public static LTDescr LeanRotateZ(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F4660", Offset = "0x2F3860", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "rotateZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001C3")]
	public static LTDescr LeanRotateZ(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F4C90", Offset = "0x2F3E90", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001C7")]
	public static LTDescr LeanScale(RectTransform rectTransform, Vector3 to, float time) { }

	[Address(RVA = "0x2F4B70", Offset = "0x2F3D70", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001C5")]
	public static LTDescr LeanScale(GameObject gameObject, Vector3 to, float time) { }

	[Address(RVA = "0x2F4BF0", Offset = "0x2F3DF0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001C6")]
	public static LTDescr LeanScale(Transform transform, Vector3 to, float time) { }

	[Address(RVA = "0x2F4870", Offset = "0x2F3A70", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scaleX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001C8")]
	public static LTDescr LeanScaleX(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F48E0", Offset = "0x2F3AE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scaleX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001C9")]
	public static LTDescr LeanScaleX(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F4970", Offset = "0x2F3B70", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scaleY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001CA")]
	public static LTDescr LeanScaleY(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F49E0", Offset = "0x2F3BE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scaleY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001CB")]
	public static LTDescr LeanScaleY(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F4B00", Offset = "0x2F3D00", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scaleZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001CC")]
	public static LTDescr LeanScaleZ(GameObject gameObject, float to, float time) { }

	[Address(RVA = "0x2F4A70", Offset = "0x2F3C70", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "scaleZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001CD")]
	public static LTDescr LeanScaleZ(Transform transform, float to, float time) { }

	[Address(RVA = "0x2F4D10", Offset = "0x2F3F10", Length = "0x79")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__2", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001DC")]
	public static void LeanSetLocalPosX(Transform transform, float val) { }

	[Address(RVA = "0x2F4D90", Offset = "0x2F3F90", Length = "0x78")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__3", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001DD")]
	public static void LeanSetLocalPosY(Transform transform, float val) { }

	[Address(RVA = "0x2F4E10", Offset = "0x2F4010", Length = "0x78")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__4", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001DE")]
	public static void LeanSetLocalPosZ(Transform transform, float val) { }

	[Address(RVA = "0x2F4E90", Offset = "0x2F4090", Length = "0x79")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__5", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001D9")]
	public static void LeanSetPosX(Transform transform, float val) { }

	[Address(RVA = "0x2F4F10", Offset = "0x2F4110", Length = "0x78")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__6", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001DA")]
	public static void LeanSetPosY(Transform transform, float val) { }

	[Address(RVA = "0x2F4F90", Offset = "0x2F4190", Length = "0x78")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__7", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60001DB")]
	public static void LeanSetPosZ(Transform transform, float val) { }

	[Address(RVA = "0x2F5010", Offset = "0x2F4210", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001CE")]
	public static LTDescr LeanSize(RectTransform rectTransform, Vector2 to, float time) { }

	[Address(RVA = "0x2F55F0", Offset = "0x2F47F0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D2")]
	public static LTDescr LeanValue(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	[Address(RVA = "0x2F5080", Offset = "0x2F4280", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D0")]
	public static LTDescr LeanValue(GameObject gameObject, float from, float to, float time) { }

	[Address(RVA = "0x2F5560", Offset = "0x2F4760", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`2<System.Single, System.Single>), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D4")]
	public static LTDescr LeanValue(GameObject gameObject, Action<Single, Single> callOnUpdate, float from, float to, float time) { }

	[Address(RVA = "0x2F53B0", Offset = "0x2F45B0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`2<System.Single, System.Object>), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D5")]
	public static LTDescr LeanValue(GameObject gameObject, Action<Single, Object> callOnUpdate, float from, float to, float time) { }

	[Address(RVA = "0x2F5110", Offset = "0x2F4310", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`1<UnityEngine.Color>), typeof(Color), typeof(Color), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D6")]
	public static LTDescr LeanValue(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	[Address(RVA = "0x2F5320", Offset = "0x2F4520", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`1<UnityEngine.Vector2>), typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D7")]
	public static LTDescr LeanValue(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	[Address(RVA = "0x2F51C0", Offset = "0x2F43C0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`1<UnityEngine.Vector3>), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D8")]
	public static LTDescr LeanValue(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	[Address(RVA = "0x2F5280", Offset = "0x2F4480", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Color), typeof(Color), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001CF")]
	public static LTDescr LeanValue(GameObject gameObject, Color from, Color to, float time) { }

	[Address(RVA = "0x2F5440", Offset = "0x2F4640", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D1")]
	public static LTDescr LeanValue(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	[Address(RVA = "0x2F54D0", Offset = "0x2F46D0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`1<System.Single>), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(LTDescr))]
	[Extension]
	[Token(Token = "0x60001D3")]
	public static LTDescr LeanValue(GameObject gameObject, Action<Single> callOnUpdate, float from, float to, float time) { }

}

