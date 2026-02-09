using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using Polytoria.Datamodel;
using Polytoria.Types;
using U8Xml;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	public class GameIO : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadFromSite_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int id;

			public GameIO _003C_003E4__this;

			public Action<bool> callback;

			private UnityWebRequest _003Cuwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadFromSite_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CModelFromSite_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int id;

			public GameIO _003C_003E4__this;

			public Instance parent;

			public Action<Instance> callback;

			private UnityWebRequest _003Cuwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CModelFromSite_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPostClearDatamodel_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameIO _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPostClearDatamodel_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private Game game;

		public static GameIO singleton;

		private List<Instance> spawnInstances;

		private void Awake()
		{
		}

		public void Load(int id, Action<bool> callback = null)
		{
		}

		public void LoadFromFile(string path, Action<bool> callback = null)
		{
		}

		public Instance LoadModelFromFile(string path, Instance parent)
		{
			return null;
		}

		public void LoadModelFromSite(int id, Instance parent, Action<Instance> callback = null)
		{
		}

		public Model LoadModelFromXmlString(string xmlString, Instance parent)
		{
			return null;
		}

		public void ClearDatamodel()
		{
		}

		[IteratorStateMachine(typeof(_003CPostClearDatamodel_003Ed__10))]
		private IEnumerator PostClearDatamodel()
		{
			return null;
		}

		public void PostMapLoad()
		{
		}

		[IteratorStateMachine(typeof(_003CModelFromSite_003Ed__12))]
		public IEnumerator ModelFromSite(int id, Instance parent, Action<Instance> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadFromSite_003Ed__13))]
		public IEnumerator LoadFromSite(int id, Action<bool> callback = null)
		{
			return null;
		}

		private Instance LoadXml(U8Xml.XmlNode xml, Instance parent = null)
		{
			return null;
		}

		private Instance HandleXmlNodes(U8Xml.XmlNodeList nodes, Instance parent)
		{
			return null;
		}

		public Vector3 XmlConvertVector3(U8Xml.XmlNode property)
		{
			return default(Vector3);
		}

		public Vector2 XmlConvertVector2(U8Xml.XmlNode property)
		{
			return default(Vector2);
		}

		public Color XmlConvertColor(U8Xml.XmlNode property)
		{
			return default(Color);
		}

		public ColorRange XmlConvertColorRange(U8Xml.XmlNode property)
		{
			return default(ColorRange);
		}

		public NumberRange XmlConvertNumberRange(U8Xml.XmlNode property)
		{
			return default(NumberRange);
		}

		public string SaveModelToString(Instance root)
		{
			return null;
		}

		public void SaveModelToFile(Instance root, string path)
		{
		}

		public string SaveToString()
		{
			return null;
		}

		public void SaveToFile(string path)
		{
		}

		private void SaveHandleChild(XmlDocument doc, Instance i, XmlElement parent)
		{
		}

		private void SaveString(XmlDocument doc, XmlElement properties, string name, string value)
		{
		}

		private void SaveFloat(XmlDocument doc, XmlElement properties, string name, float value)
		{
		}

		private void SaveInt(XmlDocument doc, XmlElement properties, string name, int value)
		{
		}

		private void SaveBool(XmlDocument doc, XmlElement properties, string name, bool value)
		{
		}

		private void SaveVector3(XmlDocument doc, XmlElement properties, string name, Vector3 value)
		{
		}

		private void SaveVector2(XmlDocument doc, XmlElement properties, string name, Vector2 value)
		{
		}

		private void SaveColor(XmlDocument doc, XmlElement properties, string name, Color value)
		{
		}

		private void SaveColorRange(XmlDocument doc, XmlElement properties, string name, ColorRange value)
		{
		}

		private void SaveNumberRange(XmlDocument doc, XmlElement properties, string name, NumberRange value)
		{
		}
	}
}
