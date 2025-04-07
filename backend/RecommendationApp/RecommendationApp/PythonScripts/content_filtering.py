import sys
import pandas as pd

def get_content_recommendations(contentID):
    # Load your content-based filtering CSV
    df = pd.read_csv('content_filtering_results.csv')

    # Simple filter by contentID and return top 5 recommended items
    recommendations = df[df['contentID'] == int(contentID)].sort_values('similarity', ascending=False).head(5)
    return recommendations['recommended_contentID'].tolist()

if __name__ == "__main__":
    contentID = sys.argv[1]
    recommendations = get_content_recommendations(contentID)
    print(recommendations)  # Output the list of recommendations as a JSON array
