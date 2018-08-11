# THI_Unity3D_OSMWorld

This project uses Unity3D to generate real world locations using OpenStreetMap data.

1. Import OpenStreetMap file.
  Go to https://www.openstreetmap.org/export. Manually select a section and export it. Convert the OSM-File to a .TXT file and import it     into your Unity3D Resources folder.
  
2. Prepare the scene in Unity
  Create a surface for the scene to be placed upon. Place the surface below the origin (in negativ y direction) as all the objects are 
  raycast down the first object they hit. Save the scene.
  
3. Load the OSM data
  Go to Window -> Import OpenMap Data -> Customize the materials and settings and click on Import Map File.
  The world will be generated. Depending on the size of the data it might take a few moments to load.
  
  All objects in the scene are listed as GameObjects in the project hierarchy in the editor. If available the GameObjects will be named     after the given name in the OSM file. Otherwise it says "noData". The generated scene has to be saved in a SEPARATE scene in order to be 
  loaded up again.
  
4. Heightmap
   To import a heightmap create a Terrain object in your scene. Select a greyscale heightmap image in your Assets folder (click on it) and
   then click on the menu item Terrain -> Heightmap From Texture. The terrain will deform according to your heightmap image.
   
5. Known issues
  Loading the scene throws an error "Instantiating mesh due to calling MeshFilter.mesh during edit mode. This will leak meshes. Please use 
  MeshFilter.sharedMesh instead." 
  This error can be ignore for now. Unity wants us to use a shared Mesh for all objects in the scene which would lead to a single 
  GameObject for the entire generated result. Making it impossible to edit the meshes individually.

  Due to possible inconsistent data in the OSM file some regions may not load throwing a FormatException: Unknown char. This happens    
  because of faulty attributes in the OSM file. It is an ongoing process to improve the code to handle all possible errors.
  
  If you use an actual heightmap the generated scene is not properly placed on top of it. Implementing it in a way that i.e. the roads 
  follow the course of the terrain properly is a huge task to tackle.
   
6. Project Hierarchy
  Roads and rooftops are hidden in the project hierarchy and thus unclickable to make the hierarchy clearer.
  In order to re-enable the roads in the hierarchy, remove the comments in line 297 in the RoadFactory class. Line 69 in the RoofFactory
  class.
  
        /* Hide Road objects in the project hierarchy to make it more readable */
        go.hideFlags = HideFlags.HideInHierarchy;
   
