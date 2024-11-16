using UnityEngine;

public class EstadoSalto: Basestate
{
    public EstadoSalto(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Salto");
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
