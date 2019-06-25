import sys

class Parser:
    def Parse(self, str):
        if (str == None):
            return None
        if (str == ""):
            return []

        parts = []
        concat = ""
        i = 0

        # this does not work for python, you cannot increment index
        #for i in range(len(str)):
        while i < len(str):
            if str[i] == '\\':
                i += 1
                if str[i] == '\\' or str[i] == ',':
                    concat += str[i]
                else:
                    raise Exception("'%s' cannot follow a slash" % str[i])
            elif (str[i] == ','):
                parts.append(concat)
                concat = ""
            else:
                concat += str[i]
            i += 1
        
        parts.append(concat)
        return parts

    def ParsePipe(self, pipe):
        parts = []
        concat = ""
        hasEscape = False
            
        while (True):
            str = pipe.read(2)

            if (str == "qq"):
                break

            i = 0

            while i < len(str):
                if str[i] == '\\':
                    hasEscape = True
                    if i < len(str)-1:
                        i += 1
                    else:
                        break

                if hasEscape:
                    if str[i] == '\\' or str[i] == ',':
                        concat += str[i]
                        hasEscape = False
                    else:
                        raise Exception("'%s' cannot follow a slash" % str[i])
                elif (str[i] == ','):
                    parts.append(concat)
                    concat = ""
                else:
                    concat += str[i]
                i += 1
            
        parts.append(concat)    
        return parts

# https://www.pythoncentral.io/python-generators-and-yield-keyword/
def GeneratorWithYields(str):
    if (str == None):
        yield None
        return
    if (str == ""):
        yield []
        return
        
    concat = ""
    i = 0

    while i < len(str):
        if str[i] == '\\':
            i += 1
            if str[i] == '\\' or str[i] == ',':
                concat += str[i]
            else:
                raise Exception("'%s' cannot follow a slash" % str[i])
        elif (str[i] == ','):
            yield concat
            concat = ""
        else:
            concat += str[i]
        i += 1
    yield concat



if __name__ == '__main__':

    p = Parser()
    print(p.Parse(None)) #None
    print(p.Parse("")) #[]
    print(p.Parse("12\\,3\\\\4, 56,")) #["12,3\4", " 56", ""]

    print
    print

    for arrayItem in GeneratorWithYields(None):
        print("'%s'" % arrayItem)
    print
    for arrayItem in GeneratorWithYields(""):
        print("'%s'" % arrayItem)
    print
    for arrayItem in GeneratorWithYields("12\\,3\\\\4, 56,"):
        print("'%s'" % arrayItem)

    print
    print

    print(p.ParsePipe(sys.stdin))