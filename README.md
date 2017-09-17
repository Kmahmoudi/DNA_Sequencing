# DNA_Sequencing
Generating a DNA sequence then chop it into random chunks then try to find the sequence by creating de bruijn graph and finding eulerian path

To show the generated graph this program uses neo4j graph database you may comment the functions which are used from graphDb module,
if you dont want to generate the graph display otherwise you need to setup neo4jClient and neo4jDriver packages and add them to your 
visual studio project in order to compile the source.
you may install the packages using nuget packet manager by the following commands
>>Install-Package Neo4j.Driver -Version 1.4.1	
>>Install-Package Neo4jClient
