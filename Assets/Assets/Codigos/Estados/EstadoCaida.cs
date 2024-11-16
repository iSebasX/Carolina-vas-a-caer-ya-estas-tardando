using UnityEngine;

public class EstadoCaida: Basestate
{
    public EstadoCaida(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Fall");
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
