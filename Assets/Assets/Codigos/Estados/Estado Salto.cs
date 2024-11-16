using UnityEngine;

public class EstadoSaltoPared: Basestate
{
    [SerializeField] private float fuerzaSalto;
    public EstadoSaltoPared(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("SaltoPared");
        controlador.rigid.AddForce(Vector2.up * fuerzaSalto);
    }
    public override void StateUpdate()
    {
        
    }
    public override void FixedUpdateState()
    {
        
    }
    public override void StateExit()
    {
        
    }

}
