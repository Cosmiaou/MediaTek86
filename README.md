# MediaTek86

MediaTek86 est une application de gestion des absences du personnel au sein d'un réseau de médiathèque. Elle a été conçue dans le cadre des mes cours du CNED.

# Précisions techniques
L'application est un fork d'un projet précédent nommé Habilitations2024. Les deux applications utilisaient à peu près la même logique, et réinventer la roue n'aurait aucun sens. Ce projet est donc dérivé du premier.
Tout commit réalisé avant le 21 mai est donc lié à l'ancien projet.

# Problèmes connus

 - Le logo de l'application n'apparaît pas. J'ai déjà essayé de rêgler ça et je n'ai pas su faire. Ce n'est probablement pas le plus important.
 - Il est possible qu'après avoir supprimé une personne, puis en avoir recréé une nouvelle personne, les absences associées à la personnes supprimées aient survécus. Ce n'est pas censé être le cas, mais quand ça arrive, il suffit de supprimer les absences non-désirés. Cela ne cause pas de problèmes logiques et ne cause aucun crash.
 - Les absences du fichier SQL sont en conflit. Cela ne cause pas de problème logique dans l'application. Cependant, certaines manipulations des absences peuvent rencontrer des conflits, puisque l'application vérifie pour toute modification/ajout d'absence l'existence ou non de conflit. Pour vos tests, je recommande de créer des absences sur un personnage vierge, 

# Origines des messages d'erreurs :
- E00 : BddManager.reqSelect
- E01 : initialisation d'Access
- E02 : PersonnelAccess.GetLesPersonnels
- E03 : PersonnelAccess.DelItem
- E04 : PersonnelAccess.AddItem
- E05 : PersonnelAccess.UpdateItem
- E07 : ServiceAccess.GetItems
- E09 : ResponsableAccess.ControleAuthentification
- E08 : BddManager.reqUpdate
- E11 : MotifAccess.GetItems
- E12 : AbsenceAccess.GetLesAbsences
- E13 : AbsenceAccess.DelItem
- E14 : AbsenceAccess.AddItem
- E15 : AbsenceAccess.UpdateItem
