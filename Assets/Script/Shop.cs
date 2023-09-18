using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint plasticTurret;

    public TurretBlueprint glassTurret;

    public TurretBlueprint electricaTurret;

    public TurretBlueprint paperTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }


    //SelectTurretToBuild(standardTurret)

    public void PurchasePlasticTurret()
    {
        Debug.Log("Plastic Turret Selected");
        buildManager.SelectTurretToBuild(plasticTurret);
    }

    public void PurchaseGlassTurret()
    {
        Debug.Log("Glass Turret Selected");
        buildManager.SelectTurretToBuild(glassTurret);

    }

    public void PurchaseElectricaTurret()
    {
        Debug.Log("Electrica Turret Selected");
        buildManager.SelectTurretToBuild(electricaTurret);

    }

    public void PurchasePaperTurret()
    {
        Debug.Log("Paper Turret Selected");
        buildManager.SelectTurretToBuild(paperTurret);

    }

}
