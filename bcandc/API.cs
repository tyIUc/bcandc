using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc
{
    public static class API
    {
        public static string GetColor(this Team team)
        {
            switch (team)
            {
                case Team.SCPs:
                    return "red";
                case Team.FoundationForces:
                    return "blue";
                case Team.ChaosInsurgency:
                    return "green";
                case Team.Scientists:
                    return "yellow";
                case Team.ClassD:
                    return "yellow";
                case Team.OtherAlive:
                    return "green";
                case Team.Dead:
                default:
                    return "white";
            }
        }
        public static string GetRolename(this RoleTypeId roleTypeId)
        {
            keyValuePairs.TryGetValue(roleTypeId, out var name);
            return name;

        }
        public static Dictionary<RoleTypeId, string> keyValuePairs = new Dictionary<RoleTypeId, string>()
    {
        {RoleTypeId.NtfPrivate,"九尾狐 列兵" },
        {RoleTypeId.NtfCaptain,"九尾狐 指挥官" },
        {RoleTypeId.NtfSergeant,"九尾狐 中士" },
        {RoleTypeId.NtfSpecialist,"九尾狐 收容专家" },
        {RoleTypeId.FacilityGuard,"设施保安" },
        {RoleTypeId.ChaosConscript,"混沌 征召兵" },
        {RoleTypeId.ChaosMarauder,"混沌 掠夺者" },
        {RoleTypeId.ChaosRepressor,"混沌 压制者" },
        {RoleTypeId.ChaosRifleman,"混沌 步枪兵" },
        {RoleTypeId.Scp096,"SCP-096" },
        {RoleTypeId.Scp049,"SCP-049" },
        {RoleTypeId.Scp173,"SCP-173" },
        {RoleTypeId.Scp939,"SCP-939" },
        {RoleTypeId.Scp106,"SCP-106" },
        {RoleTypeId.Scp0492,"SCP-049-2" },
        {RoleTypeId.Scp079,"SCP-079" },
        {RoleTypeId.ClassD,"D级人员" },
        {RoleTypeId.Scientist,"科学家" },
        {RoleTypeId.Tutorial,"训练人员" },
        {RoleTypeId.Overwatch,"观察者" },
        {RoleTypeId.CustomRole,"null" },
        {RoleTypeId.Spectator,"观察者" },
        {RoleTypeId.None,"null" }
    };
    }
}
