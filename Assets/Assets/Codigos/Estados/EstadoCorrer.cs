using UnityEngine;

public class EstadoCorrer : Basestate
{
    public EstadoCorrer(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Run");
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
