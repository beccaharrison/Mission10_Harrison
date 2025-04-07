import sys
import pandas as pd

def get_collaborative_recommendations(contentID):
    # Load your collaborative filtering CSV
    df = pd.read_csv('collaborative_filtering_results.csv')

    # Simple filter by contentID and return top 5 recommended items
    recommendations = df[df['contentID'] == int(contentID)].sort_values('score', ascending=False).head(5)
    return recommendations['recommended_contentID'].tolist()

if __name__ == "__main__":
    contentID = sys.argv[1]
    recommendations = get_collaborative_recommendations(contentID)
    print(recommendations)  # Output the list of recommendations as a JSON array
