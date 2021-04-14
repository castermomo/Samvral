using UnityEngine;


public class HitObject : BreakableObject

    private Agent Owner;
    {
        base.Initialize();

    protected override void OnDone()
    {
        //do nothing
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
