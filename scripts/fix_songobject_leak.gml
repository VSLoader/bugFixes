// Fixes cursorable song textures on the song select screen never getting freed from memory.
// Author: rosalinadev
if (variable_instance_exists(id, "surf") && surface_exists(surf))
    surface_free(surf);