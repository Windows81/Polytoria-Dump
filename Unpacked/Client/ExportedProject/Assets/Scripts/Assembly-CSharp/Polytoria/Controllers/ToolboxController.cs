using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	public class ToolboxController : MonoBehaviour
	{
		public enum ToolboxCategory
		{
			RecentlyUpdated = 0,
			UploadedModels = 1
		}

		[CompilerGenerated]
		private sealed class _003CDoReloadToolbox_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ToolboxController _003C_003E4__this;

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
			public _003CDoReloadToolbox_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CLoadThumbnail_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JSONNode entry;

			public RawImage image;

			private UnityWebRequest _003Ctwr_003E5__2;

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
			public _003CLoadThumbnail_003Ed__23(int _003C_003E1__state)
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

		[SerializeField]
		private TMP_Dropdown categorySelector;

		[SerializeField]
		private RectTransform toolboxContainer;

		[SerializeField]
		private RectTransform entryPrefab;

		[SerializeField]
		private TMP_Text pageLabel;

		private int page;

		private int pageLimit;

		private ToolboxCategory cat;

		private string searchQuery;

		public int Page
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ToolboxCategory Category
		{
			get
			{
				return default(ToolboxCategory);
			}
			set
			{
			}
		}

		public string SearchQuery
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void SetSearchQuery(string q)
		{
		}

		public void ReloadToolbox()
		{
		}

		public void PageUp()
		{
		}

		public void PageDown()
		{
		}

		[IteratorStateMachine(typeof(_003CDoReloadToolbox_003Ed__22))]
		private IEnumerator DoReloadToolbox()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadThumbnail_003Ed__23))]
		private IEnumerator LoadThumbnail(JSONNode entry, RawImage image)
		{
			return null;
		}

		public void InsertModel(int id)
		{
		}

		public void SetCategory(int c)
		{
		}
	}
}
