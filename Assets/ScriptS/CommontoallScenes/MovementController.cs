using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody rBody;
    public GameObject background;
    public float speed = 12;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //按leftshift加速
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            speed = speed * 3;
            animator.speed *= 3;
            Debug.Log(speed);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            speed = speed / 3;
             animator.speed /= 3;
            Debug.Log(speed);
        }

        //转向
        if(Input.GetKeyDown(KeyCode.A)){
            transform.rotation = new Quaternion(0,0,0,1);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            transform.rotation = new Quaternion(0,1,0,0);
        }

        //动画
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)){
            animator.SetBool("iswalk", true);
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)){
            animator.SetBool("iswalk", false);
        }
    }

    private void FixedUpdate()
    {
        //移动脚本
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), /*Input.GetAxisRaw("Vertical")*/0);
        Vector3 targetPos = rBody.position + movement * Time.deltaTime * speed;

        if(Input.GetAxisRaw("Horizontal") > 0.5)//从左向右人物与背景的相对运动
        {
            //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":95.67522430419922,"y":-14.289091110229493,"z":88.39624786376953},"rotation":{"x":0.0,"y":1.0,"z":0.0,"w":0.0},"scale":{"x":24.0,"y":24.0,"z":24.0}}
            if(this.transform.position.x < 90)
            {
                //左边界到画面中心移动人物
                if(this.transform.position.x < 0 || background.transform.position.x < -115){
                    rBody.MovePosition(targetPos);
                }
                //否则移动背景
                else{
                    background.transform.position -= movement * Time.deltaTime * speed;
                }
            }
            else
                Debug.Log("在右边界");
        }
        else//从右向左人物与背景的相对运动
        {
            //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":-94.95648193359375,"y":-14.289091110229493,"z":88.39624786376953},"rotation":{"x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{"x":24.0,"y":24.0,"z":24.0}}
            if(this.transform.position.x > -94)
            {
                 //右边界到画面中心移动人物
                if(this.transform.position.x > 0 || background.transform.position.x > 115){
                    rBody.MovePosition(targetPos);
                }
                //否则移动背景
                else{
                    background.transform.position -= movement * Time.deltaTime * speed;
                }
            }
            else
                Debug.Log("在左边界");
        }
    }

}
