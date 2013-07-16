# Date:         07/08/2013
# Description:  Program to read questions from a text file and convert to a XML grammar schema using Parts of Speech (POS) Tagger
# Author:       Raghavi Sakpal

import nltk

""" declare a global dict """
POSdict = {}
punctuationList = ['.', ',', '\\', '?', '/', '*', '-', '?', ':', '*', '+', '@', '#', '$', '&']


# Function: To write the contents of the dict to the output file
def writeToFile(outputFile):

    """ open output file to write """
    fwrite = open(outputFile, 'w')

    """ write contents of the POSdict to the output file """
    for key, value in POSdict.items():
        fwrite.write(key)
        fwrite.write('-->')
        for v in value:
            fwrite.write(v)
            fwrite.write(' ')
        fwrite.write('\n')

# Function: Create a dictionary with keys being the Parts of Speech
def createPOSdict(POStext):

    """ for each tuple in the recived list """
    for tuple in POStext:
        
        """ check if tuple[1] is not a key in POSdict and also tuple[1] is not a punctuation """
        if not tuple[1] in POSdict.keys() and not tuple[1] in punctuationList:
            POSdict[tuple[1]] = []
            POSdict[tuple[1]].append(tuple[0].lower())
        else:   
            """ find the tuple[1] key in POSdict """  
            for key, value in POSdict.items():
                if key == tuple[1]:
                    
                    """ check to see if tuple[0] exists in existing key """   
                    if tuple[0].lower() not in value:
                        
                        """ append tuple[0] to existing key value """
                        POSdict[tuple[1]].append(tuple[0].lower())     


# Function: Read contents of a question file and attach POS tags and write to output file
def POSconvertor(inputFile):
    """ Open input file to read """
    fread = open(inputFile, 'r')

    """ Read each line from the input file """
    for line in fread:

        """ Tokenize each word in the line and attach POS tags """
        lineTokenize = nltk.word_tokenize(line)
        POStext = nltk.pos_tag(lineTokenize)

        """ Send POS tags list to create a new dict """
        createPOSdict(POStext)

    """ Close both the files """
    fread.close()


# Function: Define the main function
def main():
    """ Make a function call to POSconvertor function """
    POSconvertor("questionnaireFile.txt")
    
    """ Write contents of POSdict to the output file """
    writeToFile("resultPOStag.txt")

    print "Success !"


# define call to main function
if __name__ == "__main__":
    main()

