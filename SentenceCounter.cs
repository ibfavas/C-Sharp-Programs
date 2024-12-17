namespace SentenceCounter{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter the paragraph in a line:");
            string paragraph = Console.ReadLine();

            int sentenceCount = CountSentences(paragraph);

            Console.WriteLine(sentenceCount);
        }

        static int CountSentences(string paragraph){
            
            int sentenceCount=0;

            for(int i=0;i<paragraph.Length;i++){

                if(paragraph[i]=='.'  || paragraph[i]=='?'  || paragraph[i] =='!'){

                    if(paragraph[i]=='.' && i+2<paragraph.Length && paragraph[i+1]=='.' && paragraph[i+2]=='.'){
                        continue;
                    }
                    sentenceCount++;
                }
            }
            return sentenceCount;
        }
    }
}