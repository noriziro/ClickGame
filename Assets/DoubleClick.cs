/// <summary>
/// http://tsubakit1.hateblo.jp/entry/2015/01/31/015304
/// 
/// IPointerEnterHandler
///ポインタがオブジェクトに入ったときOnPointerEnterを呼ぶ
///IPointerExitH​​andler
///ポインタがオブジェクトから出たときにOnPointerExitを呼ぶ
///IPointerDownHandler
///ポインタがオブジェクト上で押されたときにOnPointerDownを呼ぶ
///IPointerUpHandler
///ポインタがリリースされたときにOnPointerUpを呼ぶ
///IPointerClickHandler
///ポインタが同じオブジェクトに押され、解放されたときにOnPointerClickを呼ぶ
///IInitializePotentialDragHandler
///ドラッグターゲットが検出されると、値を初期化するためにOnInitializePotentialDragを呼ぶ
///IBeginDragHandler
///ドラッグ開始時にOnBeginDragを呼ぶ
///IDragHandler
///ドラッグ中にOnDragを呼ぶ
///IEndDragHandler
///ドラッグ終了時にOnEndDragを呼ぶ
///IDropHandler 
///ドロップ時にOnDropを呼ぶ
///IScrollHandler
///マウススクロール時にOnScrollを呼ぶ
///IUpdateSelectedHandler
///各チック選択時にOnUpdateSelectedを呼ぶ
///ISelectHandler
///選択時にOnSelectを呼ぶ
///IDeselectHandler
///選択解除時にOnDeselectを呼ぶ
///IMoveHandler
///移動イベントが発生したときにOnMoveを呼ぶ
///ISubmitHandler
///Submitが押された時にOnSubmitを呼ぶ
///ICancelHandler
///キャンセル時にOnCancelを呼ぶ
/// </summary>

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DoubleClick : MonoBehaviour, IPointerClickHandler 
{
	public void OnPointerClick (PointerEventData eventData)
	{
		//if( eventData.clickCount > 1 ){
			Debug.Log(eventData.clickCount);
		//}
	}
}