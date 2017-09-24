using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using UUEX.UI;
using UUEX.UI.Effects;
using UUEX.UI.Tutorial;

public class Test : MonoBehaviour
{
	public UI _Ui = null;
	public TutorialManager _TutorialManager;


	public void Update()
	{
		if (Input.GetKeyUp (KeyCode.D)) 
		{
			//AddItem("BtnItem1", "BtnNewName", mLayoutGroup.transform);
			//Debug.Log ("Adding the item");
			
			UIItem item = _Ui.GetItem ("BtnItem1");
			UIItem newItem = item.Clone ();
			newItem.SetName ("R");
			//_Ui.AddItem (newItem, mLayoutGroup.transform);
		}
		else if (Input.GetKeyUp (KeyCode.R)) 
		{
			// RemoveItem("BtnItem1");
			//UIItem item = GetItem("BtnItem1");
			//item.AddClickListener(someFunction);
			
			//AddClickListener(someFunction);
			
			//UIItem item = GetItem("BtnItem3");
			//Texture2D tex = ResourceManager.GetAtlas("Superman");
			//item.SetTexture(tex);
			
			string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
			UIImage item = (UIImage)_Ui.GetItem("BtnItem3");
			item.SetTextureFromURL(url);
			
			url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
			//url = "http://images.freshnessmag.com/wp-content/uploads/2009/08/canon-powershot-g11-digital-camera-01-570x537.jpg";
			UIButton buttonItem = (UIButton)_Ui.GetItem("BtnItem2");
			buttonItem.SetTextureFromURL(url);
			
			/*UUEX.UI.WWWTexture texture = new UUEX.UI.WWWTexture("http://images.earthcam.com/ec_metros/ourcams/fridays.jpg");
				texture.StartDownloading(EventHandler, null);*/
			
		}
		else if(Input.GetKeyUp(KeyCode.C))
		{
			/*SetRowCount(2);

				SetCellSize(80,80);
				SetPadding(10,10,10,10);
				SetSpacing(20,20);*/
			
			//GetRowCount();
			//Debug.Log ("count is " + GetPageCount());
			//GotoPage(4);
			
			//UIItem item = GetItem("BtnItem1");
			//item.SetItemData(item);
			
			//TestData td = new TestData();
			//item.SetItemData(td);
			
			//SetPosition(10,10);

			_TutorialManager.AddStepUpdateListener(TutorialStepUpdate);

		}
		else if(Input.GetKeyUp(KeyCode.F))
		{
			//_Ui.FadeIn(EffectDone,0.5f,"FadeInMan", true, 5);
			//_Ui.ColorLerpIn(EffectDone,Color.red,0.5f,"ColorLerpMan",true,5);

			FadeInOut fadeInOut = _Ui.gameObject.AddComponent<FadeInOut>();
			fadeInOut._Ui = null;
			fadeInOut._Listener = EffectDone;
			fadeInOut._UiItem = _Ui.GetItem("Toggle");
			fadeInOut._Duration = 0.5f;
			fadeInOut._FadeInValue = 0.0f;
			fadeInOut._FadeOutValue = 1.0f;
			fadeInOut._YoYo = true;
			fadeInOut._RepeatCount = 5;
			fadeInOut.PlayIn();


			/*ColorInOutEffect colorEffect = _Ui.gameObject.AddComponent<ColorInOutEffect>();
			colorEffect._Ui = null;
			colorEffect._Listener = EffectDone;
			colorEffect._UiItem = _Ui.GetItem("Toggle");
			colorEffect._Listener = EffectDone;
			colorEffect._Duration = 0.5f;
			colorEffect._TargetColor = Color.red;
			colorEffect._YoYo = true;
			colorEffect._RepeatCount = 5;*/
			//colorEffect.ColorIn();
		}
		else if(Input.GetKeyUp(KeyCode.G))
		{
			//if(transform.parent.name.Contains("Vertical"))
				//_Ui.SetExclusive();
			//FadeOut();

			//_Ui.FadeOut(EffectDone,1.5f,"FadeOutMan", true);
		}
		else if(Input.GetKeyUp(KeyCode.Q))
		{
			if(transform.parent.name.Contains("Horizontal"))
				_Ui.SetExclusive();
		}
	}

	public void TutorialStepUpdate(NormalStep step, StepAction action)
	{
		Debug.Log ("Update coming in " + step._ItemName + " : " + action.ToString ());
	}

	public void EffectDone(string effectName, UIBase ui)
	{
		Debug.Log ("Done done done " + effectName);
	}
}
