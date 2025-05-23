# MediaTek86

MediaTek86 est une application de gestion des absences du personnel au sein d'un réseau de médiathèque. Elle a été conçue dans le cadre des mes cours du CNED.

# Précisions techniques
L'application est un fork d'un projet précédent nommé Habilitations2024. Les deux applications utilisaient à peu près la même logique, et réinventer la roue n'aurait aucun sens. Ce projet est donc dérivé du premier.
Tout commit réalisé avant le 21 mai est donc lié à l'ancien projet.

# Problèmes connus

 - Le logo de l'application n'apparaît pas. J'ai déjà essayé de rêgler ça et je n'ai pas su faire. Ce n'est probablement pas le plus important.

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
