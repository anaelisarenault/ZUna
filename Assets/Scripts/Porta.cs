using System.Collections; using System.Collections.Generic; using UnityEngine;  public class Porta : MonoBehaviour
{

    public float timeleft = 0;

    public RaycastHit hit;

    public Transform currentdoor;

    public bool open;

    public bool IsOpeningDoor;

    public Transform cam;

    public LayerMask mask;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && timeleft == 0.0f)
            CheckDoor();

        if (IsOpeningDoor)
            OpenAndCloseDoor();
    }


    public void CheckDoor()
    {
        if (Physics.Raycast(cam.position, cam.forward, out hit, 5, mask))
        {
            open = false;
            if (hit.transform.localRotation.eulerAngles.y > 45)
                open = true;

            IsOpeningDoor = true;
            currentdoor = hit.transform;

        }
    }

    public void OpenAndCloseDoor()
    {

        timeleft += Time.deltaTime;
        if (open)
            currentdoor.localRotation = Quaternion.Slerp(currentdoor.localRotation, Quaternion.Euler(0, 0, 0), timeleft);
        else
            currentdoor.localRotation = Quaternion.Slerp(currentdoor.localRotation, Quaternion.Euler(0, 90, 0), timeleft);
        if (timeleft > 1)
        {
            timeleft = 0;
            IsOpeningDoor = false;
        }
    } }


